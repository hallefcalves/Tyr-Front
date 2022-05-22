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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FazGetAll(Rotas.GetAllContainers);
        }

        private void tabCont_Click(object sender, EventArgs e)
        {

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
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = usuarios.ToString();
            }
            else
            {
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = "erro: " + usuarios.ToString();
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
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = usuarios.ToString();
            }
            else
            {
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = "erro: " + usuarios.ToString();
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
            //    var usuarios = response.Content.ReadAsStringAsync().Result;
            //    txtDados.Text = usuarios.ToString();

            //}
            //else
            //{
            //    var usuarios = response.Content.ReadAsStringAsync().Result;
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
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = usuarios.ToString();
            }
            else
            {
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = "erro: " + usuarios.ToString();
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
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = usuarios.ToString();
            }
            else
            {
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = "erro: " + usuarios.ToString();
            }
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
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = usuarios.ToString();
            }
            else
            {
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = "erro: " + usuarios.ToString();
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
                var usuarios = response.Content.ReadAsStringAsync().Result;
                return usuarios.ToString();
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
