using System.Text;

namespace Entidades
{
    public sealed class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        #region Builders

        /// <summary>
        /// Builds the entity with all its parameters and sets the type of glass by default value.
        /// </summary>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = Botella.Tipo.Vidrio;
        }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="tipo">Type of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : this(capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        protected string GenerarInforme()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.ToString());
            data.Append($"Tipo: {this.tipo}.\n");
            data.Append($"Medida: {MEDIDA}.\n");

            return data.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            if (MEDIDA <= this.Contenido)
            {
                this.Contenido = (int)(this.Contenido - MEDIDA * 0.8);
            }
            else if (MEDIDA > this.Contenido)
            {
                this.Contenido -= this.Contenido;
            }

            return this.Contenido;
        }

        #endregion

        #region Operator

        /// <summary>
        /// Shows the type of the bottle.
        /// </summary>
        /// <param name="cerveza">Beer class to check its type.</param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        #endregion
    }
}
