using SAPbobsCOM;
// add > referance > SapBusinessOneSDK.Dll
Company company =new Company();
            company.Server = "ServerName";
            company.CompanyDB = "CompanyDB";
            company.DbServerType = BoDataServerTypes.dst_MSSQL2017;
            company.UserName = tbxUserName.Text;
            company.Password = tbxPassword.Text;
            company.language = BoSuppLangs.ln_Turkish_Tr;//language

            company.Connect();
            var error = company.GetLastErrorDescription();

            if (company.Connected)
            {
                MessageBox.Show("Successfull");
            }
            else
            {
                
                MessageBox.Show(error);
            }