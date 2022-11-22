using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ukupholisa_Healthcare
{
    class Datahandler
    {
        string conn = "Server=.; Initial Catalog = Ukupholisa Healthcare; Integrated Security = SSPI";
        public Datahandler() { }

        

        ////////////////////////////Policy maintenance methods///////////////////////////////////////////////

        //Policy Insert method
        public bool InsertPolicy(Policy policy)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Policy VALUES('{policy.PolicyID}', '{policy.PackageTear}', '{policy.Packagetype}', '{policy.PackageStatus}', '{policy.Price}') ";

                SqlCommand AddPolicy = new SqlCommand(query, connection);

                AddPolicy.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        //Policy Update method
        public bool UpdatePolicy(Policy policy)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"UPDATE Policy SET Package_tear = '{policy.PackageTear}', Package_type = '{policy.Packagetype}'," +
                        $" Package_Status = '{policy.PackageStatus}', Price = '{policy.Price}' WHERE Policy_ID = '{policy.PolicyID}'";

                SqlCommand UpdatePolicy = new SqlCommand(query, connection);
               
                UpdatePolicy.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }

        //Policy Delete method
        public bool DeletePolicy(Policy policy)
        {          
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Policy WHERE Policy_ID = '{policy.PolicyID}'";

                SqlCommand DeletePolicy = new SqlCommand(query, connection);
               
                DeletePolicy.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {             
                return false;
            }         
        }

        //Policy View Method 
        public DataTable ViewAllPolicies()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Policy";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Policy Search Method
        public DataTable SearchPolicy(int Id)
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Policy WHERE Policy_ID = '{Id}'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }






        ////////////////////////////////////Medical Department/////////////////////////////////////////////////////////
        ///Medical condition Insert method
        public bool InsertCondition(MedicalCondition condition)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Condition VALUES('{condition.ConditionID}','{condition.ConditionName}') ";

                SqlCommand AddCondition = new SqlCommand(query, connection);

                AddCondition.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Medical condition Update method
        public bool UpdateCondition(MedicalCondition condition)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"UPDATE Condition SET Condition_name = '{condition.ConditionName}' WHERE Condition_ID = '{condition.ConditionID}'";
                       

                SqlCommand UpdateCondition = new SqlCommand(query, connection);

                UpdateCondition.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Medical condition Delete method
        public bool DeleteCondition(MedicalCondition condition)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Condition WHERE Condition_ID = {condition.ConditionID}";

                SqlCommand DeleteCondition = new SqlCommand(query, connection);

                DeleteCondition.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Medical condition View all Method
        public DataTable ViewAllConditions()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Condition";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Medical condition Search Method
        public DataTable SearchCondition(int Id)
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Condition WHERE Condition_ID = '{Id}'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }







        /////////////////////////Condition Treatment Insert method////////////////////////////////
        public bool InsertConditionTreatment(ConditionTreatment conditionTreatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Condition_treatment VALUES('{conditionTreatment.TreatmentID}','{conditionTreatment.ConditionID}') ";

                SqlCommand AddConditionTreatment = new SqlCommand(query, connection);

                AddConditionTreatment.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Condition Treatment Update method
        /*public bool UpdateConditionTreatment(ConditionTreatment conditionTreatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"UPDATE Condition_treatment SET Treatment_ID = '{conditionTreatment.TreatmentID}', Condition_ID = '{conditionTreatment.ConditionID}' WHERE Treatment_ID = '{conditionTreatment.TreatmentID}' AND Condition_ID = '{conditionTreatment.ConditionID}'";


                SqlCommand UpdateCondition = new SqlCommand(query, connection);

                UpdateCondition.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }*/

        //Condition Treatment Delete method
        public bool DeleteConditionTreatment(ConditionTreatment conditionTreatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Condition_treatment WHERE Treatment_ID = {conditionTreatment.TreatmentID} AND Condition_ID = {conditionTreatment.ConditionID}";

                SqlCommand DeleteConditionTreatment = new SqlCommand(query, connection);

                DeleteConditionTreatment.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        //View all conditions and their treatments
        public DataTable ViewAllConditionsAndTreatments()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Condition_treatment INNER JOIN Treatment ON Treatment.Treatment_ID = Condition_treatment.Treatment_ID INNER JOIN Condition ON Condition.Condition_ID = Condition_treatment.Condition_ID";
          
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }







        //////////////////////////////////ProductMaintenance////////////////////////////////////////
        ///Product Treatment Insert method
        public bool InsertTreatment(Treatment treatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Treatment VALUES('{treatment.TreatmentID}','{treatment.TreatmentName}') ";

                SqlCommand AddTreatment = new SqlCommand(query, connection);

                AddTreatment.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Product Treatment Update method
        public bool UpdateTreatment(Treatment treatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"UPDATE Treatment SET Treatment_name = '{treatment.TreatmentName}' WHERE Treatment_ID = '{treatment.TreatmentID}'";


                SqlCommand UpdateTreatment = new SqlCommand(query, connection);

                UpdateTreatment.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Product Treatment Delete method
        public bool DeleteTreatment(Treatment treatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Treatment WHERE Treatment_ID = '{treatment.TreatmentID}'";

                SqlCommand DeleteTreatment = new SqlCommand(query, connection);

                DeleteTreatment.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Product Treatment View all method
        public DataTable ViewAllTreatments()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Treatment";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Product Treatment Search method
        public DataTable SearchTreatment(int Id)
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Treatment WHERE Treatment_ID = '{Id}'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }






        ///////////////////////////////////Treatment Policies/////////////////////////////////////
        ///Treatment policy Insert method
        public bool InsertTreatmentPolicy(PolicyTreatmentPackage treatmentPolicy)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Policy_Treatment VALUES('{treatmentPolicy.PolicyID}','{treatmentPolicy.TreatmentID}') ";

                SqlCommand AddTreatmentPolicy = new SqlCommand(query, connection);

                AddTreatmentPolicy.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Treatment Policy Delete method
        public bool DeletePolicyTreatments(PolicyTreatmentPackage treatmentPolicy)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Policy_Treatment WHERE Policy_ID = {treatmentPolicy.PolicyID} AND Treatment_ID = {treatmentPolicy.TreatmentID}";

                SqlCommand DeleteTreatmentPolicy = new SqlCommand(query, connection);

                DeleteTreatmentPolicy.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        //View all policies and their treatments
        public DataTable ViewAllPolicyTreatments()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Policy_Treatment INNER JOIN Policy ON Policy.Policy_ID = Policy_Treatment.Policy_ID INNER JOIN Treatment ON Treatment.Treatment_ID = Policy_Treatment.Treatment_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //////////////////////////Client Maintenance///////////////////////////////////////////
        ///Client Insert Method
        public bool InsertClient(Client client)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Client VALUES('{client.ClientID}','{client.NationalID}','{client.MemberSatus}','{client.FirstName}','{client.LastName}','{client.DOB}', '{client.StreetNumberAndName}', '{client.CityName}', '{client.PostalCode}', '{client.CellNumber}', '{client.Email}', '{client.PolicyID}') ";

                SqlCommand AddClient = new SqlCommand(query, connection);

                AddClient.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Client Update method
        public bool UpdateClient(Client client)
        {
           
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"UPDATE Client SET National_ID = '{client.NationalID}', Member_Status = '{client.MemberSatus}', First_name = '{client.FirstName}', Last_name = '{client.LastName}', DOB = '{client.DOB}', Street_Number_Name = '{client.StreetNumberAndName}', City = '{client.CityName}', Postal_Code = '{client.PostalCode}', Cell_number = '{client.CellNumber}', Email = '{client.Email}', Policy_ID = '{client.PolicyID}'   WHERE Client_ID = '{client.ClientID}'";


                SqlCommand UpdateClient = new SqlCommand(query, connection);

                UpdateClient.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Client Delete method
        public bool DeleteClient(Client client)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Client WHERE Client_ID = {client.ClientID}";

                SqlCommand DeleteClient = new SqlCommand(query, connection);

                DeleteClient.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Client view all method
        public DataTable ViewAllClients()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Client";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Client Search method
        public DataTable SearchClient(int Id)
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Client WHERE Client_ID = '{Id}'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }




        /////////////////////////////////ProviderForClient/////////////////////////////////////////
        ///ProviderClient Insert method
        public bool InsertProviderClient(ProviderForClient providerForClient)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Provider_Client VALUES('{providerForClient.ProviderID}','{providerForClient.ClientID}') ";

                SqlCommand AddProviderClient = new SqlCommand(query, connection);

                AddProviderClient.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Provider Client Delete method
        public bool DeleteProviderClient(ProviderForClient providerForClient)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Provider_Client WHERE Provider_ID = {providerForClient.ProviderID} AND Client_ID = {providerForClient.ClientID}";

                SqlCommand DeleteProviderClient = new SqlCommand(query, connection);

                DeleteProviderClient.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //View all clients and their providers
        public DataTable ViewAllClientsAndProviders()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Provider_Client INNER JOIN Client ON Client.Client_ID = Provider_Client.Client_ID INNER JOIN Provider ON Provider.Provider_ID = Provider_Client.Provider_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }



        /////////////////////////////Client Condition///////////////////////////////////////////  
        ///Insert Client Condition method
        public bool InsertClientCondition(ClientCondition clientCondition)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Client_Condition VALUES('{clientCondition.ClientID}','{clientCondition.ConditionID}') ";

                SqlCommand AddClientCondition = new SqlCommand(query, connection);

                AddClientCondition.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Client condition Delete method
        public bool DeleteClientCondition(ClientCondition clientCondition)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Client_Condition WHERE Client_ID = {clientCondition.ClientID} AND Condition_ID = {clientCondition.ConditionID}";

                SqlCommand DeleteClientCondition = new SqlCommand(query, connection);

                DeleteClientCondition.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //View all clients and their conditions
        public DataTable ViewAllClientsAndConditions()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Client_Condition INNER JOIN Client ON Client.Client_ID = Client_Condition.Client_ID INNER JOIN Condition ON Condition.Condition_ID = Client_Condition.Condition_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /////////////////////////Client Policy/////////////////////////////////////////
        //View Clients and their polcies
        public DataTable ViewAllClientsAndPolicies()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Client INNER JOIN Policy ON Client.Policy_ID = Policy.Policy_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        /////////////////////Client Treatment//////////////////////////////////////////////
        ///Insert client treatment method
        public bool InsertClientTreatment(ClientTreatment clientTreatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Client_Treatment VALUES('{clientTreatment.ClientID}','{clientTreatment.TreatmentID}') ";

                SqlCommand AddClientTreatment = new SqlCommand(query, connection);

                AddClientTreatment.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Client Treatment Delete method
        public bool DeleteClientTreatment(ClientTreatment clientTreatment)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Client_Treatment WHERE Client_ID = {clientTreatment.ClientID} AND Treatment_ID = {clientTreatment.TreatmentID}";

                SqlCommand DeleteClientTreatment = new SqlCommand(query, connection);

                DeleteClientTreatment.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //View all clients and their treatments
        public DataTable ViewAllClientsAndTreatments()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Client_Treatment INNER JOIN Client ON Client.Client_ID = Client_Treatment.Client_ID INNER JOIN Treatment ON Treatment.Treatment_ID = Client_Treatment.Treatment_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        ///////////////////////////////////Provider Management////////////////////////////////////
        //Provider Management Insert method
        public bool InsertProvider(MedicalProvider provider)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Provider VALUES('{provider.ProviderID}','{provider.ProviderName}','{provider.Status}','{provider.City}','{provider.StreetNumberAndName}','{provider.PostalCode}') ";

                SqlCommand AddProvider = new SqlCommand(query, connection);

                AddProvider.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Provider management update method
        public bool UpdateProvider(MedicalProvider provider)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"UPDATE Provider SET Provider_Name = '{provider.ProviderName}', Provider_Status = '{provider.Status}', City = '{provider.City}', Street_Number_Name = '{provider.StreetNumberAndName}', Postal_Code = '{provider.PostalCode}' WHERE Provider_ID = '{provider.ProviderID}'";


                SqlCommand UpdateProvider = new SqlCommand(query, connection);

                UpdateProvider.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        ///Provider management Delete method
        public bool DeleteProvider(MedicalProvider provider)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Provider WHERE Provider_ID = {provider.ProviderID}";

                SqlCommand DeleteProvider = new SqlCommand(query, connection);

                DeleteProvider.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Provider management view all method
        public DataTable ViewAllProviders()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Provider";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Provider management Search method
        public DataTable SearchProvider(int Id)
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Provider WHERE Provider_ID = '{Id}'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }






        ////////////////////Treatment Provider/////////////////////////////////////////////////
        ///Treatment Provider Insert Method
        public bool InsertTreatmentProvider(TreatmentProvider treatmentProvider)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Treatment_Provider VALUES('{treatmentProvider.ProviderID}','{treatmentProvider.TreatmentID}') ";

                SqlCommand AddTreatmentProvider = new SqlCommand(query, connection);

                AddTreatmentProvider.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Treatment Policy Delete method
        public bool DeleteTreatmentProvider(TreatmentProvider treatmentProvider)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"DELETE FROM Treatment_Provider WHERE Provider_ID = {treatmentProvider.ProviderID} AND Treatment_ID = {treatmentProvider.TreatmentID}";

                SqlCommand DeleteTreatmentProvider = new SqlCommand(query, connection);

                DeleteTreatmentProvider.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        //View all policies and their treatments
        public DataTable ViewAllTreatmentProviders()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Unsuccessful");
            }

            string query = $"SELECT * FROM Treatment_Provider INNER JOIN Provider ON Provider.Provider_ID = Treatment_Provider.Provider_ID INNER JOIN Treatment ON Treatment.Treatment_ID = Treatment_Provider.Treatment_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /////////////////////////////ClaimForm methods////////////////////////////////////////////
        ///Insert claim method
        public bool InsertClaim(Claims claims)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                string query = $"INSERT INTO Claim VALUES('{claims.ClaimID}','{claims.Condition}','{claims.Treatment}','{claims.Provider}','{claims.ClientID}','{claims.Date}') ";

                SqlCommand AddClaim = new SqlCommand(query, connection);

                AddClaim.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
