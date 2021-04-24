using System.Text;

namespace Entidades
{
    public abstract class Botella
    {
        private int capacidadML;
        private int contenidoML;
        private string marca;

        #region Properties

        /// <summary>
        /// Get: Gets the capacity of the bottle in liters.
        /// </summary>
        protected float CapacidadLitros
        {
            get
            {
                return this.capacidadML/ 1000;
            }
        }

        /// <summary>
        /// Get: Gets the Content of the bottle in ml.
        /// Set: Sets the content of the bottle in ml.
        /// </summary>
        protected int Contenido
        {
            get
            {
                return this.contenidoML;
            }

            set
            {
                if (value > 0)
                {
                    this.contenidoML = value;
                }
                else
                {
                    this.contenidoML = 0;
                }
            }
        }

        /// <summary>
        /// Get: Gets the percentaje of content of the bottle.
        /// </summary>
        protected float PorcentajeContenido
        {
            get
            {
               return (this.contenidoML * 100 / this.capacidadML);
            }
         
        }

        #endregion

        #region Builder

        /// <summary>
        /// Full constructor of the entity.
        /// </summary>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            if (capacidadML < contenidoML)
            {
                this.capacidadML = contenidoML;
            }
            else
            {
                this.capacidadML = capacidadML;
            }
            this.contenidoML = contenidoML;
        }

        #endregion

        /// <summary>
        /// Tipes of Bottles.
        /// </summary>
        public enum Tipo
        {
            Plastico,
            Vidrio
        }

        #region Methods

        /// <summary>
        /// Returns the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        protected string GenerarInforme()
        {
            StringBuilder data = new StringBuilder();
            data.Append($"Marca: {this.marca}.\n");
            data.Append($"Capacidad: {this.CapacidadLitros}Lts.\n");
            data.Append($"Contenido: {this.Contenido}Ml.\n");
            data.Append($"Porcentaje Contenido: {this.PorcentajeContenido}%.\n");

            return data.ToString();
        }

        public abstract int ServirMedida();

        /// <summary>
        /// Returns the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        public override string ToString()
        {
            return GenerarInforme();
        }

        #endregion
    }
}
