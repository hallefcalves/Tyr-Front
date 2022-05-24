using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace ServicosRedeN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtDados.RowHeadersVisible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FazGetAll(Rotas.GetAllContainers);
        }

        private void tabCont_Click(object sender, EventArgs e)
        {

        }

        public void msgBoxErro(string msg)
        {
            MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void msgBoxSucesso(string msg)
        {
            MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCriaCont_Click(object sender, EventArgs e)
        {
            FazPostContainer();
        }

        HttpClient client;
        public void PreApi()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(txtUrl.Text);
            client.DefaultRequestHeaders.Accept.Add(new
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        class Rotas
        {
            public static readonly string GetAllContainers = "/containers/";
            public static readonly string CreateContainer = "/containers/create";
            public static readonly string DeleteAContainer = "/containers/delete";// + nome
            public static readonly string DeleteAllContainers = "/containers/deleteall";
            public static readonly string GetAllImages = "/images/";
            public static readonly string PullImage = "/images/pull";
            public static readonly string DeleteImage = "/images/delete";// + nome
            public static readonly string DeleteAllImages = "/images/deleteall";
        }


        public void FazPostContainer()
        {
            PreApi();

            if (!Valido(txtNomeCont.Text))
                return;
            
            string json = $"{{\"name\":\"{txtNomeCont.Text}\", \"image\":\"{cbxImg.Text}\", \"port\":\"{txtPortaCont.Value}\"}}";
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            System.Net.Http.HttpResponseMessage response =
            client.PostAsync(Rotas.CreateContainer, httpContent).Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                msgBoxSucesso("Container Criado com sucesso");
                //txtDados.Text = dadosRetorno.ToString();
            }
            else
            {
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                msgBoxErro("Erro ao criar container: "+ dadosRetorno.ToString());
                //txtDados.Text = "erro: " + dadosRetorno.ToString();
            }
        }

        public void FazPostImage()
        {
            PreApi();
            if (!Valido(txtNomeImg.Text))
                return;

            string json = $"{{\"name\":\"{txtNomeImg.Text}\", \"tag\":\"{txtTagImg.Text}\"}}";
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            System.Net.Http.HttpResponseMessage response =
            client.PostAsync(Rotas.PullImage, httpContent).Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = dadosRetorno.ToString();
                msgBoxSucesso("Imagem obtida com sucesso");
            }
            else
            {
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                msgBoxErro("Erro ao obter imagem: " + dadosRetorno.ToString());
            }
        }

        public bool Valido(string str)
        {
            return str.Trim() != string.Empty;
        }

       
        public void FazGet()
        {

            //System.Net.Http.HttpResponseMessage response =
            //client.GetAsync($"{Rotas.GetAllContainers}//{txtCodigo.Value}").Result;
            //se retornar com sucesso busca os dados
            //if (response.IsSuccessStatusCode)
            //{//pegando o cabeçalho
            //    Uri usuarioUri = response.Headers.Location;
            //    //Pegando os dados do Rest e armazenando na variável usuários
            //    var dadosRetorno = response.Content.ReadAsStringAsync().Result;
            //    txtDados.Text = dadosRetorno.ToString();

            //}
            //else
            //{
            //    var dadosRetorno = response.Content.ReadAsStringAsync().Result;
            //}
        }

        public void FazDelete(string rota, string nomeDel)
        {
            PreApi();
            System.Net.Http.HttpResponseMessage response =
            client.DeleteAsync($"{rota}/{nomeDel}").Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                msgBoxSucesso("Deletado com sucesso!");
                //txtDados.Text = ;
            }
            else
            {
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                msgBoxErro("Erro ao deletar: " + dadosRetorno.ToString());
            }
        }

        public void FazDeleteAll(string rota)
        {
            PreApi();
            System.Net.Http.HttpResponseMessage response =
            client.DeleteAsync(rota).Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                msgBoxSucesso("Deletados com sucesso!");
            }
            else
            {
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                msgBoxErro("Erro ao deletar: " + dadosRetorno.ToString());
            }
        }

        class Container
        {
            public string Id { get; set; }
            public string[] Names { get; set; }
            public string Image { get; set; }
            public Port[] Ports { get; set; }
        }

        class Port
        {
            public string IP { get; set; }
            public int PrivatePort { get; set; }
            public int PublicPort { get; set; }
            public string Type { get; set; }
        }
        
         
        public void FazGetAll(string rota)
        {
            PreApi();
            System.Net.Http.HttpResponseMessage response =
            client.GetAsync(rota).Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                //

                if(rota == Rotas.GetAllContainers)
                {
                    Container[] containers = JsonSerializer.Deserialize<Container[]>(dadosRetorno.ToString());
                    DataTable dt = new DataTable();
                    dtDados.Columns.Clear();
                    //dtDados.Rows.Clear();
                    dt.Columns.Add("Nome");
                    dt.Columns.Add("Imagem");
                    dt.Columns.Add("IP");
                    dt.Columns.Add("Porta Privada");
                    dt.Columns.Add("Porta Publica");
                    dt.Columns.Add("Type");
                    dt.Columns.Add("Id");
                    foreach (var item in containers)
                    {
                        if (item.Ports == null || item.Ports.Length == 0)
                            item.Ports = new Port[] {new Port()};
                        dt.Rows.Add(item.Names[0].Trim('/'), item.Image, item.Ports[0].IP , item.Ports[0].PrivatePort.ToString(), item.Ports[0].PublicPort.ToString(), item.Ports[0].Type, item.Id);
                        //txtDados.Text = txtDados.Text + Environment.NewLine + $"Id: {item.Id}, Imagem: {item.Image}, IP: {item.Ports[0].IP}, Porta Privada: {item.Ports[0].PrivatePort}, Porta Publica: {item.Ports[0].PublicPort}, Type: {item.Ports[0].Type}";
                    }

                    dtDados.DataSource = dt;
                    //txtDados.Text = dadosRetorno.ToString();
                }
                else
                {
                    Imagem[] img = JsonSerializer.Deserialize<Imagem[]>(dadosRetorno.ToString());
                    DataTable dt = new DataTable();
                    dtDados.Columns.Clear();
                    //dtDados.Rows.Clear();
                    dt.Columns.Add("Nome da Imagem");
                    dt.Columns.Add("Tag");
                    foreach (var item in img)
                    {
                        dt.Rows.Add(item.RepoTags[0].Split(':')[0], item.RepoTags[0].Split(':')[1]);
                        //cbxImg.Items.Add(item.RepoTags[0]);
                    }
                    dtDados.DataSource = dt;
                    //txtDados.Text = dadosRetorno.ToString();
                }

            }
            else
            {
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = "erro: " + dadosRetorno.ToString();
            }
        }

        public string FazGetAllReturn(string rota)
        {
            PreApi();
            System.Net.Http.HttpResponseMessage response =
            client.GetAsync(rota).Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var dadosRetorno = response.Content.ReadAsStringAsync().Result;
                return dadosRetorno.ToString();
            }
            else
            {
                return "";
            }
        }

        private void btnDeletaCont_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deletar todos?", "Confimação", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
                FazDeleteAll(Rotas.DeleteAllContainers);
        }

        private void btnDeleta1Cont_Click(object sender, EventArgs e)
        {
            if (!Valido(txtNomeContDel.Text))
                return;
            FazDelete(Rotas.DeleteAContainer, txtNomeContDel.Text);
        }

        private void btnPullImg_Click(object sender, EventArgs e)
        {
            FazPostImage();
        }

        private void btnDeletaImg_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deletar todos?", "Confimação", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                FazDeleteAll(Rotas.DeleteAllImages);
        }

        private void btnDeleta1Img_Click(object sender, EventArgs e)
        {
            if (!Valido(txtNomeDelImg.Text))
                return;
            FazDelete(Rotas.DeleteImage, txtNomeDelImg.Text);
        }

        private void btnListaImgs_Click(object sender, EventArgs e)
        {
            FazGetAll(Rotas.GetAllImages);
        }

        class Imagem
        {
            public string[] RepoTags { get; set; } 
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtDados.Columns.Clear();
            //dtDados.Rows.Clear();
            txtDados.Clear();
            cbxImg.Items.Clear();
            Imagem[] img = JsonSerializer.Deserialize<Imagem[]>(FazGetAllReturn(Rotas.GetAllImages));
            foreach (var item in img)
            {
                cbxImg.Items.Add(item.RepoTags[0]);
            }
        }
    }
}
