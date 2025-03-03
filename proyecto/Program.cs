// See https://aka.ms/new-console-template for more information





var lista_clientes=new List<Clientes>();
lista_clientes.Add(new Clientes(){id_cliente=1, nombre_cliente= "juan", apellido_cliente= "perez", direccion_cliente="calle 104", telefono_cliente=35044531});

foreach(var elemento in lista_clientes){
    Console.Write(elemento.id_cliente);
    Console.Write(elemento.nombre_cliente);
    Console.Write(elemento.apellido_cliente);
    Console.Write(elemento.direccion_cliente);
    Console.Write(elemento.telefono_cliente);
}

public class Clientes{
    public int id_cliente {get;set;}
    public string? nombre_cliente {get;set;}
    public string? apellido_cliente {get;set;}
    public string? direccion_cliente {get;set;}
    public int telefono_cliente {get;set;}


}

public class Discos{
    public int id_disco {get;set;}
    public string? nombre_disco {get;set;}
    public int id_artista {get;set;} //foranea 
    public int duracion {get;set;}
    public DateTime fecha_lanzamiento {get;set;}
    public string? descripcion {get;set;}

    public int id_marca {get;set;}//foranea

    public Artistas? _artista {get;set;}//para la foranea
    public Marcas? _marca {get;set;} //para la foranea
}

public class Ordenes{
    public int id_orden {get;set;}
    public DateTime fecha {get;set;}
    public int id_cliente {get;set;} //foranea
    
    public string? descripcion {get;set;}

    public int id_pago {get;set;} //foranea

    public int monto_total {get;set;}

    public Clientes? _cliente {get;set;} //para la foranea
    public Pagos? _pago {get;set;} //para la foranea

    
}

public class Formatos{
    public int id_formato {get;set;}
    public string? tipo_formato {get;set;}
    public string? material {get;set;}
}

public class Artistas{
    public int id_Artista {get;set;}
    public string? nombre_artista {get;set;}
    public string? genero_musical {get;set;}
}

public class Ordenes_discos{
    public int id_orden_disco {get;set;}

    public int id_orden {get;set;} //foranea
    
    public int cantidad {get;set;}

    public int id_disco {get;set;} //foranea

    public int id_formato {get;set;} //foranea
    public double valor_unitario {get;set;}

    public Ordenes orden_ {get;set;} //para la foranea
    public Discos disco_ {get;set;} //para la foranea

    public Formatos formato_{get;set;} //para la foranea


    
}

public class Pagos{
    public int id_pago {get;set;}
    public string? tipo_pago {get;set;}
    public string? pais_disponibilidad {get;set;}
}

public class Marcas{
    public int id_marca {get;set;}
    public string? nombre_marca {get;set;}
    public string? sitio_web {get;set;}
}


    
