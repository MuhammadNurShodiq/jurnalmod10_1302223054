namespace jurnalmodul10_1302223054
{
    public class Mahasiswa
    {
        public string Name {  get; set; }
        public string Nim {  get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(string nama, string nim, List<string> course, int year)
        {
            this.Name = nama;
            this.Nim = nim; 
            this.Course = course;
            this.Year = year;
        }

        public Mahasiswa() { }

    }
}
