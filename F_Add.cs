using Google.Apis.PeopleService.v1.Data;

namespace Restaurante
{
    public partial class F_Add : Form
    {
        TextBoxBase[] txb = new TextBoxBase[6];
        F_Principal UFA = new();
        public F_Add(F_Principal OF)
        {
            InitializeComponent();
            #region Declarate Variables
            txb[0] = tb_1;
            txb[1] = mb_2;
            txb[2] = tb_3;
            txb[3] = tb_4;
            txb[4] = tb_5;
            txb[5] = tb_6;
            UFA = OF;
            #endregion

            txb[0].Text = OF.cb_1.Text;
            if(OF.cb_2.Text.Length == 8)//Separate cellphone and landline
            {
                string x = OF.cb_2.Text;
                x = x.Substring(0, 1);
                x = (x != "9" && x != "8" && x != "7") ? "  " : "9";
                txb[1].Text = "  " + x + OF.cb_2.Text;
            }
            else
            {
                btn_11.Visible = false;
                btn_13.Visible = false;
            }
            txb[2].Text=OF.tb_3.Text;
            txb[3].Text=OF.tb_4.Text;
            txb[4].Text=OF.tb_5.Text;
            txb[5].Text=OF.tb_6.Text;
        }
        private void btn_add_Click(object sender, EventArgs e)//Add Contact Button
        {
            if (txb[0].Text.Length > 0 && txb[1].Text.Length == 15)
            {
                Cursor.Current = Cursors.WaitCursor;
                btn_add.Enabled = false;
                try
                {
                    CreateClient();
                }
                catch (AggregateException ex)
                {
                    foreach (var ie in ex.InnerExceptions)
                    {
                        MessageBox.Show("ERROR: " + ie.Message);
                    }
                }
                Cursor.Current = DefaultCursor;
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha os Dados");
            }
        }
        private void btn_ddd_Click(object sender, EventArgs e)//Single button of ddd 011 013
        {
            Button btn = (Button)sender;
            string hi = btn.Text.Replace("0", "");
            txb[1].Text = txb[1].Text.ReplaceAt(0, 3, hi);
        }
        private void CreateClient()//Create new contact to GoogleContacs and add to datatable
        {
            string phone = txb[1].Text.Replace("(", "");
            phone = phone.Replace(")", "");
            phone = phone.Replace(" ","");
            phone = "+55"+phone;
            string adress = txb[2].Text + " - " + txb[3].Text;

            Person person = new()
            {
                Names = new List<Name>() { new Name() { GivenName = txb[0].Text } },
                PhoneNumbers = new List<PhoneNumber>() { new PhoneNumber() { Value = phone } },
                Addresses = new List<Address>() { new Address() { StreetAddress = adress, ExtendedAddress = txb[4].Text } },
                Biographies = new List<Biography>() { new Biography() { Value = txb[5].Text } }
            };

            string resourcePeople = UFA.tabela.Rows[UFA.selectedindex]["Pessoa"].ToString();
            var request = UFA.service.People.CreateContact(person);
            request.Execute();
            //etag precisa receber de la para saber
            //PAREI AQUI
            //funciona o add, porem esse que foi adicionado não poderá ser alterado... a n ser q seja resetado o sistema.
            MessageBox.Show(person.ETag);//retorna vazio
            UFA.AddEditClient(resourcePeople,person.ETag,txb[0].Text,phone,txb[2].Text,txb[3].Text,txb[4].Text,txb[5].Text);
        }
        private void btn_clear_Click(object sender, EventArgs e)//Clear button
        {
            for(int x=0;x<6;x++)
            {
                txb[x].Text = "";
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)//Exit button
        {
            this.Close();
        }
    }
}
