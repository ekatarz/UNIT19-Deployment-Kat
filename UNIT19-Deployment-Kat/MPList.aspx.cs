using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace UNIT19_Deployment_Kat
{
    public partial class MPList : System.Web.UI.Page
    {
        // DataTable to store all MPs data
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate DataTable with sample data
                dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("PersonID", typeof(int)),
                    new DataColumn("FirstName", typeof(string)),
                    new DataColumn("LastName", typeof(string)),
                    new DataColumn("Party", typeof(string)),
                    new DataColumn("Constituency", typeof(string)),
                    new DataColumn("URI", typeof(string))
                });
                PopulateDataTable();
                BindGridView();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Filter DataTable based on search criteria
            string searchKeyword = txtSearch.Text.Trim();
            DataTable filteredTable = dt.AsEnumerable().Where(row =>
                row.Field<string>("FirstName").Contains(searchKeyword) ||
                row.Field<string>("LastName").Contains(searchKeyword) ||
                row.Field<string>("Party").Contains(searchKeyword) ||
                row.Field<string>("Constituency").Contains(searchKeyword))
                .CopyToDataTable();
            // Rebind GridView with filtered DataTable
            gvMPList.DataSource = filteredTable;
            gvMPList.DataBind();
        }

        // Method to populate DataTable with sample data
        private void PopulateDataTable()
        {
            dt.Rows.Add(10001, "Diane", "Abbott", "Independent", "Hackney North and Stoke Newington", "https://www.theyworkforyou.com/mp/10001/diane_abbott/hackney_north_and_stoke_newington");
            dt.Rows.Add(25034, "Debbie", "Abrahams", "Labour", "Oldham East and Saddleworth", "https://www.theyworkforyou.com/mp/25034/debbie_abrahams/oldham_east_and_saddleworth");
            dt.Rows.Add(25661, "Bim", "Afolami", "Conservative", "Hitchin and Harpenden", "https://www.theyworkforyou.com/mp/25661/bim_afolami/hitchin_and_harpenden");
            dt.Rows.Add(11929, "Adam", "Afriyie", "Conservative", "Windsor", "https://www.theyworkforyou.com/mp/11929/adam_afriyie/windsor");
            dt.Rows.Add(25817, "Nickie", "Aiken", "Conservative", "Cities of London and Westminster", "https://www.theyworkforyou.com/mp/25817/nickie_aiken/cities_of_london_and_westminster");
            dt.Rows.Add(24904, "Peter", "Aldous", "Conservative", "Waveney", "https://www.theyworkforyou.com/mp/24904/peter_aldous/waveney");
            dt.Rows.Add(24958, "Rushanara", "Ali", "Labour", "Bethnal Green and Bow", "https://www.theyworkforyou.com/mp/24958/rushanara_ali/bethnal_green_and_bow");
            dt.Rows.Add(25888, "Tahir", "Ali", "Labour", "Birmingham, Hall Green", "https://www.theyworkforyou.com/mp/25888/tahir_ali/birmingham%2C_hall_green");
            dt.Rows.Add(25337, "Lucy", "Allan", "Conservative", "Telford", "https://www.theyworkforyou.com/mp/25337/lucy_allan/telford");
            dt.Rows.Add(25579, "Rosena", "Allin-Khan", "Labour", "Tooting", "https://www.theyworkforyou.com/mp/25579/rosena_allin-khan/tooting");
            dt.Rows.Add(25702, "Mike", "Amesbury", "Labour", "Weaver Vale", "https://www.theyworkforyou.com/mp/25702/mike_amesbury/weaver_vale");
            dt.Rows.Add(25813, "Fleur", "Anderson", "Labour", "Putney", "https://www.theyworkforyou.com/mp/25813/fleur_anderson/putney");
            dt.Rows.Add(25894, "Lee", "Anderson", "Conservative", "Ashfield", "https://www.theyworkforyou.com/mp/25894/lee_anderson/ashfield");
            dt.Rows.Add(25818, "Stuart", "Anderson", "Conservative", "Wolverhampton South West", "https://www.theyworkforyou.com/mp/25818/stuart_anderson/wolverhampton_south_west");
            dt.Rows.Add(24864, "Stuart", "Andrew", "Conservative", "Pudsey", "https://www.theyworkforyou.com/mp/24864/stuart_andrew/pudsey");
            dt.Rows.Add(25335, "Caroline", "Ansell", "Conservative", "Eastbourne", "https://www.theyworkforyou.com/mp/25335/caroline_ansell/eastbourne");
        }

        // Method to bind DataTable to GridView
        private void BindGridView()
        {
            gvMPList.DataSource = dt;
            gvMPList.DataBind();
        }
    }
}
