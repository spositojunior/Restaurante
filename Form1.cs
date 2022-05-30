using System.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;


namespace Restaurante
{
    public partial class F_Principal : Form
    {
        internal DataTable tabela = new();
        internal PeopleServiceService service = new();
        internal int vid = 0;
        internal int selectedindex;// referente ao index selecionado para add ou edit
        bool dontRunBGL = true;
        public F_Principal()
        {
            InitializeComponent();
            #region DataTable set to receive Contacts
            tabela.Columns.Add("Nome", typeof(string));
            tabela.Columns.Add("Tel", typeof(string));
            tabela.Columns.Add("Rua", typeof(string));
            tabela.Columns.Add("Bairro", typeof(string));
            tabela.Columns.Add("Num", typeof(string));
            tabela.Columns.Add("Info", typeof(string));
            tabela.Columns.Add("TelHalf", typeof(string));
            tabela.Columns.Add("Pessoa", typeof(string));
            tabela.Columns.Add("Etag", typeof(string));
            #endregion
            try
            {
                RunOauth().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    MessageBox.Show("ERROR: " + e.Message);
                }
            }
            GetSetClient_DataTable();
        }
        // vou precisar para INICIAR, (botoes) = editar contato/ novo contato/
        private async Task RunOauth()//Autorização do Google
        {
            UserCredential credential;
            using (var stream = new FileStream(@"D:\JuninhoDesktop\mi\Programação\C# donet2\ConsoleTEST\ConsoleTEST\awe.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    new[] { PeopleServiceService.Scope.Contacts, PeopleServiceService.Scope.ContactsReadonly },
                    "user", CancellationToken.None, new FileDataStore("Books.ListMyLibrary"));
            }
            // Create the service.
            service = new PeopleServiceService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Contacts",
            });
        }//xx
        private void GetSetClient_DataTable()//Receive clients from Google contacts to this temp data
        {
            PeopleResource.ConnectionsResource.ListRequest peopleRequest = service.People.Connections.List("people/me");
            peopleRequest.PersonFields = "names,phoneNumbers,Addresses,Biographies";
            peopleRequest.PageSize = 1000;
            ListConnectionsResponse connectionsResponse = peopleRequest.Execute();

            if (connectionsResponse != null && connectionsResponse.Connections != null && connectionsResponse.Connections.Count > 0)
            {
                foreach (var person in connectionsResponse.Connections)
                {
                    DataRow row = tabela.NewRow();
                    row["Nome"] = person.Names != null ? (person.Names[0].DisplayName) : "n/a";
                    row["Tel"] = Convert.ToString(person.PhoneNumbers?.FirstOrDefault()?.Value);
                    string tel = (string)row["Tel"];
                    tel = tel.Replace("-", "");
                    tel = tel.Remove(0, tel.Length - 8);
                    string fstreet = person.Addresses != null ? (person.Addresses[0].StreetAddress) : "n/a - n/a";
                    string[] street = fstreet.Split(" - ");
                    row["Rua"] = street[0];
                    row["Bairro"] = street[1];
                    row["Num"] = person.Addresses != null ? (person.Addresses[0].ExtendedAddress) : "n/a";
                    row["Info"] = person.Biographies != null ? (person.Biographies[0].Value) : "";
                    row["TelHalf"] = tel;
                    row["Pessoa"] = person.ResourceName;
                    row["Etag"] = person.ETag;
                    tabela.Rows.Add(row);
                    //se tiver endereço e não tiver o traço... vai ser um problema... TO FIX
                }

                tabela.DefaultView.Sort = "Nome";
                tabela = tabela.DefaultView.ToTable();
            }
            cb_1.DataSource = tabela;
            cb_1.DisplayMember = "Nome";
            cb_1.SelectedItem = null;
            cb_2.DataSource = tabela;
            cb_2.DisplayMember = "TelHalf";
            cb_2.SelectedItem = null;

            dontRunBGL = false;
        }//to fix 1
        public void AddEditClient(string p,string e,params string[] t)//Set new data sort Contact to this temp data
        {
            dontRunBGL = true;

            cb_1.DataSource = null;
            cb_2.DataSource = null;

            DataTable temp = tabela;
            DataRow row = temp.NewRow();

            row["Nome"] = t[0];
            row["Tel"] = t[1];
            row["Rua"] = t[2] ?? "n/a";
            row["Bairro"] = t[3] ?? "n/a";
            row["Num"] = t[4] ?? "n/a";
            row["Info"] = t[5] ?? "";
            t[1] = t[1].Replace("-", "");
            t[1] = t[1].Remove(0, t[1].Length - 8);
            row["TelHalf"] = t[1];
            row["Pessoa"] = p;
            row["Etag"] = e;
            temp.Rows.Add(row);
            tabela = temp;
            tabela.DefaultView.Sort = "Nome";
            tabela = tabela.DefaultView.ToTable();
            cb_1.DataSource = tabela;
            cb_1.DisplayMember = "Nome";
            cb_1.SelectedItem = null;
            cb_2.DataSource = tabela;
            cb_2.DisplayMember = "TelHalf";
            cb_2.SelectedItem = null;

            dontRunBGL = false;
        }
        private void btnzoado_Click(object sender, EventArgs e)// botao inutil por enquanto, apenas pra jogar dados no listview
        {
            string[] pr = new string[9];
            vid++;
            pr[0] = vid.ToString();//id
            pr[1] = cb_1.Text;
            pr[2] = tb_6.Text;
            pr[3] = "R$ 15,50";
            pr[4] = "Cartão";
            pr[5] = "-";
            pr[6] = "14:00";
            pr[7] = "16:00";
            pr[8] = "x";

            //0/id 1/nome 2/pedido 3/valor 4/pagamento 5/troco 6/entrada 7/saida 8/limite
            ListViewItem l = new(pr);
                        
            lv_pedidos.Items.Add(l);
        }
        private void CB_1e2_SelectedIndexChanged(object sender, EventArgs e)// 
        {
            if (dontRunBGL) return;
            dontRunBGL = true;
            ComboBox cb = (ComboBox)sender;
            ComboBox cbx;
            //cb_2.SelectedItem = ; cotninuar aqui, em vez de setar... vai é selecionar
            if (cb == cb_1) cbx = cb_2; else cbx = cb_1;
            selectedindex = cb.SelectedIndex;
            //cbx.SelectedItem = cb.SelectedIndex;
            cbx.Text = tabela.Rows[cb.SelectedIndex][(cb==cb_1)?"TelHalf":"Nome"].ToString();
            tb_3.Text = tabela.Rows[cb.SelectedIndex]["Rua"].ToString();
            tb_4.Text = tabela.Rows[cb.SelectedIndex]["Bairro"].ToString();
            tb_5.Text = tabela.Rows[cb.SelectedIndex]["Num"].ToString();
            tb_6.Text = tabela.Rows[cb.SelectedIndex]["Info"].ToString();
            Enabled_Change();
            textBox1.Text = cb.SelectedIndex.ToString();
            dontRunBGL = false;
            //cb_2.Text = dt.Rows[cb_1.SelectedIndex]["Tel"].ToString();  BACKUP isso aqui extrai do bd
        }//Single action
        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontRunBGL) return;
            dontRunBGL = true;
            //cb_2.SelectedItem = ; cotninuar aqui, em vez de setar... vai é selecionar
            cb_2.Text = tabela.Rows[cb_1.SelectedIndex]["TelHalf"].ToString();
            tb_3.Text = tabela.Rows[cb_1.SelectedIndex]["Rua"].ToString();
            tb_4.Text = tabela.Rows[cb_1.SelectedIndex]["Bairro"].ToString();
            tb_5.Text = tabela.Rows[cb_1.SelectedIndex]["Num"].ToString();
            tb_6.Text = tabela.Rows[cb_1.SelectedIndex]["Info"].ToString();
            Enabled_Change();
            dontRunBGL = false;
        }//TO DELETE - OLD COMMAND
        private void cb_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontRunBGL) return;
            dontRunBGL = true;
            cb_1.Text = tabela.Rows[cb_2.SelectedIndex]["Nome"].ToString();
            tb_3.Text = tabela.Rows[cb_2.SelectedIndex]["Rua"].ToString();
            tb_4.Text = tabela.Rows[cb_2.SelectedIndex]["Bairro"].ToString();
            tb_5.Text = tabela.Rows[cb_2.SelectedIndex]["Num"].ToString();
            tb_6.Text = tabela.Rows[cb_2.SelectedIndex]["Info"].ToString();
            Enabled_Change();
            dontRunBGL = false;
        }//TO DELETE - OLD COMMAND
        private void cb_1e2_TextChanged(object sender, EventArgs e)
        {
            if(cb_1.Text.Length == 0 && cb_2.Text.Length == 0)
            {
                cb_1.Text = "";
                cb_2.Text = "";
                tb_3.Enabled = true;
                tb_4.Enabled = true;
                tb_5.Enabled = true;
                btn_add.Enabled = true;
                btn_edit.Enabled = false;
                tb_3.Text = "";
                tb_4.Text = "";
                tb_5.Text = "";
                tb_6.Text = "";
            }
        }//Single action - clear other information
        private void Enabled_Change()//Activator on/off buttons
        {
            tb_3.Enabled = false;
            tb_4.Enabled = false;
            tb_5.Enabled = false;
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
        }
        private void cb_2_KeyPress(object sender, KeyPressEventArgs e)//Cancels digit chars from cb Telefone
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }
        private void btn_add_MouseHover(object sender, EventArgs e)//Fazer mais desses... tips in buttons
        {
            tp_btn_add.Show("Adiciona um novo contato,\nusando as informações acima.",btn_add);
        }
        private void btn_add_Click(object sender, EventArgs e)//Button Adicionar - new form
        {
            F_Add form2 = new F_Add(this);
            form2.ShowDialog();
        }
        private void btn_edit_Click(object sender, EventArgs e)// NÃO TERMINADO
        {
            F_Edit f_edit = new F_Edit(this);
            f_edit.ShowDialog();
            //MessageBox.Show(cb_1.Items.IndexOf(tabela.Rows).ToString()); test
        }
        private void btn_clear_Click(object sender, EventArgs e)//Clear all textboxs
        {
            cb_1.Text = "";
            cb_2.Text = "";
            tb_3.Enabled = true;
            tb_4.Enabled = true;
            tb_5.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            tb_3.Text = "";
            tb_4.Text = "";
            tb_5.Text = "";
            tb_6.Text = "";
        }
        private void F_Principal_Resize(object sender, EventArgs e)//Resize listview when Form is resized
        {
            Control control = (Control)sender;
            //do...
        }
    }
}