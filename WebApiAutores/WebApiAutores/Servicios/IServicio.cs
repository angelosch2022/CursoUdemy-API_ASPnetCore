namespace WebApiAutores.Servicios
{
    public interface IServicio
    {
        void Realizartarea();
    }

    public class ServicioA : IServicio
    {
        public void Realizartarea()
        {
            throw new NotImplementedException();
        }
    }

    public class ServicioB : IServicio
    {
        public void Realizartarea()
        {
            throw new NotImplementedException();
        }
    }


}
