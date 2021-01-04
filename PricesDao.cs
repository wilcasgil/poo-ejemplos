using System;

namespace arraysExample
{
    class PricesDao
    {
        public readonly static int INDIVDUAL_PRICE = 2500;
        public readonly static int DOUBLE_PRICE = 4600;
        public readonly static int FAMILIAR_PRICE = 5200;
    }
}

/*
    En c #, readonly es una palabra clave que es útil para definir campos de solo lectura en nuestras aplicaciones.
    Los valores de campo de solo lectura deben inicializarse en la declaración o en un constructor de la misma clase
    a diferencia de la palabra clave constante en c # .

    En c #, si usamos una readonlypalabra clave para definir el campo de solo lectura, entonces el valor del campo no
    se puede cambiar una vez que la ejecución del constructor ha finalizado, por lo que no deberíamos usar la readonly 
    palabra clave con los campos cuyo valor se cambiará en cualquier momento.
*/