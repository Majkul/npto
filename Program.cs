// minecraft funny momenmts

namespace kartoteka
{
class Osoba
{
    public string imie {get;set;}
    public string nazwisko {get;set;}
    public Osoba(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }
    public string getImie(){
        return imie;
    }
    public string getNazwisko(){
        return nazwisko;
    }
    public override bool Equals(object obj){
        if (this == obj) return true;
        if (obj == null || this.GetType() != obj.GetType())
            return false;
        Osoba osob = (Osoba)obj;
        if (this.imie == osob.imie && this.nazwisko == osob.nazwisko)
            return true;
        return false;
    }
}
    namespace mockup{
        public class Kartoteka{
            public void dodaj(Osoba obj);
            public void usun(Osoba obj);
            public int rozmiar() => 1;
            public bool czyZawiera(Osoba obj) => true;
            public Osoba pobierz(int index) => new Osoba("Gall", "Anonim");
        }
    }
    namespace impl{
        class Kartoterka{
            private List<Osoba> osoby = new List<Osoba>();
            public void dodaj(Osoba obj){
                this.osoby.Add(obj);
            }
            public void usun(Osoba obj){
                this.osoby.Remove(obj);
            }
            public int rozmiar() => this.osoby.Count;
            public bool czyZawiera(Osoba obj) => this.osoby.Contains(obj);
            public Osoba pobierz(int index)=> this.osoby[index];
            public override string ToString(){
                string result = "";
                foreach(Osoba i in osoby){
                    result += i.imie + " " + i.nazwisko + "\n";
                }
                return result;
            }
            //Klasy zrobione chyba git trzeba przetestować jeszcze wszystko i wgl co nie, pozdro
        }
    }
}

//To jest zmiana do NPTO
