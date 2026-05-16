using System.Data;
using Npgsql; 

namespace Semana6Crud
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Mamapapa;Database=Semana6crud";

        private int clienteIdSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM \"clientes\"";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Actualizarbttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DataGridViewRow fila = dataGridView1.CurrentRow;
            int idFromRow = Convert.ToInt32(fila.Cells["cliente_id"].Value);

            if (clienteIdSeleccionado == 0 || clienteIdSeleccionado != idFromRow)
            {
                clienteIdSeleccionado = idFromRow;
                Nombretxtbox.Text = fila.Cells["nombre"].Value?.ToString() ?? "";
                Apellidotxtbox.Text = fila.Cells["apellido"].Value?.ToString() ?? "";
                Direcciontxtbox.Text = fila.Cells["direccion"].Value?.ToString() ?? "";
                // User can now edit the TextBoxes and press the button again to save
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, direccion = @direccion WHERE cliente_id = @cliente_id";
                using (var cmd = new NpgsqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("nombre", Nombretxtbox.Text);
                    cmd.Parameters.AddWithValue("apellido", Apellidotxtbox.Text);
                    cmd.Parameters.AddWithValue("direccion", Direcciontxtbox.Text);
                    cmd.Parameters.AddWithValue("cliente_id", clienteIdSeleccionado);
                    cmd.ExecuteNonQuery();
                }


                string selectQuery = "SELECT * FROM clientes";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(selectQuery, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }

        private void dataGridViewdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Eliminarbttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["cliente_id"].Value);

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM clientes WHERE cliente_id = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                string selectQuery = "SELECT * FROM clientes";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(selectQuery, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }


        private void Crearbttn_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=Mamapapa;Database=Semana6crud";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO clientes (nombre, apellido, direccion) VALUES (@nombre, @apellido, @direccion)";


                using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("nombre", Nombretxtbox.Text);
                    cmd.Parameters.AddWithValue("apellido", Apellidotxtbox.Text);
                    cmd.Parameters.AddWithValue("direccion", Direcciontxtbox.Text);

                    cmd.ExecuteNonQuery();
                }

                string selectQuery = "SELECT * FROM clientes";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(selectQuery, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Direcciontxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClienteIdtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}