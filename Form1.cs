namespace SistemaMatricula
{
    public partial class Matricula : Form
    {

        public List<DadosEstudante> MatriculasRealizadas { get; private set; } = new List<DadosEstudante>();
        public Matricula()
        {
            InitializeComponent();
        }

        private void bt_matricular_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = input_nome.Text;
                var matricula = input_matricula.Text;
                var disciplina = input_disciplina.Text;


                // Verificação de matrículas duplicadas em uma mesma disciplina.
                foreach (var dado in MatriculasRealizadas)
                {
                    if (dado.Matricula == matricula)
                    {
                        if (dado.Disciplina == disciplina)
                        {
                            MessageBox.Show($"{dado.Nome} já realizou uma matrícula nessa disciplina.");
                            return;
                        }
                    }
                }

                var cadastro = new DadosEstudante(nome, matricula, disciplina);
                MatriculasRealizadas.Add(cadastro);

                lista_matriculados.Items.Add(new ListViewItem(new String[] { nome, matricula, disciplina }));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}