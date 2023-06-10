namespace CuadradoFerPoo.Entidades
{
    public class Cuadrado
    {
        //Atributos
        private int lado;

		//Properties
		public int Lado
		{
			get { return lado; }
			set { lado = value; }
		}
        //Constructor
        public Cuadrado(int medidaLado)
        {
            Lado= medidaLado;
        }
        //Métodos
        public int GetPerimetro() => Lado * 4;
        public double GetSuperficie() => Math.Pow(Lado, 2);
        public bool Validar() => Lado > 0;

        //metodos sobreescritos
        public override string ToString()
        {
            return $"Cuadrado de lado {Lado}";
        }
    }
}