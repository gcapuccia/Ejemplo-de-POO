var alumno1=new Alumno();
alumno1.Nombre="Facundo";
alumno1.Apellido="Perez";
alumno1.Edad=22;

var alumno2=new Alumno();
alumno2.Nombre="Brenda";
alumno2.Apellido="Laporte";
alumno2.Edad=34;
alumno1.Inscripto=false;
alumno2.Inscripto=false;

Console.WriteLine("Nombre alumno 1: " + alumno1.Nombre);
alumno1.Inscribirse();
Console.WriteLine($"Está inscripto? {alumno1.Inscripto}");
Console.WriteLine($"Está inscripto? {alumno2.Inscripto}");
Console.WriteLine("Nombre alumno 2: " + alumno2.Nombre + " " + alumno2.Apellido);
alumno1.Cursar();
alumno2.Cursar();

class Alumno {
    public string Nombre{get;set;}
    public string Apellido{get;set;}
    public int Edad{get;set;}

    public bool Inscripto {get;set;}
    public DateTime FechaNacimiento{get;set;}

    public void Inscribirse(){
        Inscripto=true;
    }
    public void Cursar(){
        /*
        if(Inscripto)
            Console.WriteLine("Cursando");
        else
            Console.WriteLine("No estoy inscripto y no puedo cursar.");
        */
        if(Inscripto==true){
            Console.WriteLine("Cursando");
        }
        else{
            Console.WriteLine("No estoy inscripto y no puedo cursar.");
        }
    }
}
