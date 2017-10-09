using System;
namespace MathGame {
    public class Data {
            public int preguntas { get; set; }

            public string nombre { get; set; }

            public override string ToString() {
                return nombre;
            }
    }
}