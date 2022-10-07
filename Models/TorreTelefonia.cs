namespace DesafioPOO.Models
{
    // Classe estática, contém apenas membros estáticos, não pode ser instanciada e não pode ter construtores.
    public static class TorreTelefonia
    {
        private static bool TemSinal = true;

        public static bool VerificarSinal()
        {
            return TemSinal;
        }

        public static void AlternarSinal()
        {
            TemSinal = !TemSinal;
        }
    }
}