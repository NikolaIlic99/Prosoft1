using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        SqlConnection connection;

        public Broker()
        {
            this.connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                                Initial Catalog=Baza2;Integrated Security=True;
                                                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False;
                                                MultipleActiveResultSets=true") ;
        }

        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        public List<Emisija> VratiSveEmisije(Producent p)
        {
            SqlCommand comm = new SqlCommand("", connection);
            comm.CommandText = $"Select * from Emisija where ImeProducenta='{p.Firstname}' and PrezimeProducenta='{p.Lastname}' ";  // 
            List<Emisija> emisije = new List<Emisija>();
            using (SqlDataReader reader= comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    Emisija e = new Emisija();
                    e.EmisijaId = (int)reader["EmisijaId"];
                    e.Naziv = (string)reader["Naziv"];
                    e.VremePocetka = (DateTime)reader["VremePocetka"];
                    e.VremeZavrsetka = (DateTime)reader["VremeZavrsetka"];
                    Producent prod = new Producent();
                    prod.Firstname= (string)reader["ImeProducenta"];
                    prod.Lastname= (string)reader["PrezimeProducenta"];
                    e.Producent = prod;
                    e.Voditelj = VratiRadnika((int)reader["Voditelj"]);
                    e.Angazovanja = VratiSvaAngazovanja((int)reader["EmisijaId"]);
                    emisije.Add(e);
                }
            }
            return emisije;
        }

        public List<Radnik> VratiSveRadnike()
        {
            SqlCommand comm = new SqlCommand("", connection);
            comm.CommandText = $"Select * from Radnik";
            List<Radnik> lista = new List<Radnik>();
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    Radnik r = new Radnik();
                    r.Radnikid = (int)reader["RadnikID"];
                    r.Ime = (string)reader["Ime"];
                    r.Prezime = (string)reader["Prezime"];
                    lista.Add(r);
                }
            }
            return lista;
        }

        public Radnik VratiRadnika(int radnikID)
        {
            SqlCommand comm = new SqlCommand("", connection);
            comm.CommandText = $"Select * from Radnik where RadnikId={radnikID} ";
            Radnik r = new Radnik();
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {

                    r.Radnikid = (int)reader["RadnikID"];
                    r.Ime = (string)reader["Ime"];
                    r.Prezime = (string)reader["Prezime"];
                }
            }
            return r;
        }

        public List<Angazovanje> VratiSvaAngazovanja(int emisijaId)
        {
            SqlCommand comm = new SqlCommand("", connection);
            comm.CommandText = $"Select * from Angazovanje where EmisijaId={emisijaId} ";
            List<Angazovanje> angazovanja = new List<Angazovanje>();
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    Angazovanje a = new Angazovanje();
                    a.EmisijaId = emisijaId;
                    a.RedniBroj = (int)reader["RedniBroj"];
                    a.VrstaAngazovanja= (VrstaAngazovanja)reader["VrstaAngazovanja"];
                    a.OpisPosla= (string)reader["OpisPosla"];
                    a.Trajanje= (int)reader["Trajanje"];
                    a.Radnik = VratiRadnika((int)reader["RadnikId"]);
                    angazovanja.Add(a);
                }
            }
            return angazovanja;
        }


        public void UnesiNovuEmisiju(Emisija emisija)
        {
            SqlCommand comm = new SqlCommand("", connection);
            comm.CommandText = $"Insert into Emisija Values(@Naziv, @VremePocetka, @VremeZavrsetka, @ImeProducenta, @PrezimeProducenta, @Voditelj)";
            //comm.Parameters.AddWithValue("@EmisijaId", emisija.EmisijaId);
            comm.Parameters.AddWithValue("@Naziv", emisija.Naziv);
            comm.Parameters.AddWithValue("@VremePocetka", emisija.VremePocetka);
            comm.Parameters.AddWithValue("@VremeZavrsetka", emisija.VremePocetka);
            comm.Parameters.AddWithValue("@ImeProducenta", emisija.Producent.Firstname);
            comm.Parameters.AddWithValue("@PrezimeProducenta", emisija.Producent.Lastname);
            comm.Parameters.AddWithValue("@Voditelj", emisija.Voditelj.Radnikid);


            comm.ExecuteNonQuery();
        }


    }
}
    

