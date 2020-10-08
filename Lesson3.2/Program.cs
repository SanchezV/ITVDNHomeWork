using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._2
{
    public class ClassRoom
    {
        public Pupil[] myClass = new Pupil[4];
        public ClassRoom(Pupil pupil1)
        {
                myClass[0] = pupil1;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            myClass[0] = pupil1;
            myClass[1] = pupil1;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            myClass[0] = pupil1;
            myClass[1] = pupil2;
            myClass[2] = pupil3;
        }
        public void Add(Pupil pupil)
        {
             myClass[3] = pupil;
        }
    }
    public class Pupil
    {
        public string study, read, write, relax;
        public Pupil(string study, string read, string write, string relax)
        {
            this.study = study;
            this.read = read;
            this.write = write;
            this.relax = relax;
        }
        public virtual void Study(string study)
        {

        }

        public virtual void Read(string read)
        {

        }
        public virtual void Write(string write)
        {

        }

        public virtual void Relax(string relax)
        {

        }
        public void Show()
        {
            Console.WriteLine($"Ученик {study} {read} {write} {relax}");
        }
    }

    public class ExelentPupil : Pupil
    {
        public ExelentPupil(string study = "Ученик учится на отлично!",
            string read = "Ученик читает очень много книг!",
            string write = "Ученик обладает превосходной грамотностью!",
            string relax = "Ученик мало отдыхает!")
        : base(study, read, write, relax) { }
        public override void Study(string study)
        {
            base.study = study;
            Console.WriteLine(study);
        }
        public override void Read(string read)
        {
            base.read = read;
            Console.WriteLine(read);
        }
        public override void Write(string write)
        {
            base.write = write;
            Console.WriteLine(write);
        }
        public override void Relax(string relax)
        {
            base.relax = relax;
            Console.WriteLine(relax);
        }
    }
    public class GoodPupil : Pupil
    {
        public GoodPupil(string study = "Ученик учится на хорошо!",
            string read = "Ученик читает много книг!",
            string write = "Ученик обладает неплохой грамотностью!",
            string relax = "Ученик пашет как папа Карло!")
        : base(study, read, write, relax) { }
        public override void Study(string study)
        {
            base.study = study;
            Console.WriteLine(study);
        }
        public override void Read(string read)
        {
            base.read = read;
            Console.WriteLine(read);
        }
        public override void Write(string write)
        {
            base.write = write;
            Console.WriteLine(write);
        }
        public override void Relax(string relax)
        {
            base.relax = relax;
            Console.WriteLine(relax);
        }
    }
    public class BadPupil : Pupil
    {
        public BadPupil(string study = "Ученик учится на удовлетворительно!",
            string read = "Ученик читает очень мало книг!",
            string write = "Ученик обладает низкой грамотностью!",
            string relax = "Ученик отдыхает на полную катушку!")
        : base(study, read, write, relax) { }
        public override void Study(string study)
        {
            base.study = study;
            Console.WriteLine(study);
        }
        public override void Read(string read)
        {
            base.read = read;
            Console.WriteLine(read);
        }
        public override void Write(string write)
        {
            base.write = write;
            Console.WriteLine(write);
        }
        public override void Relax(string relax)
        {
            base.relax = relax;
            Console.WriteLine(relax);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new BadPupil(), new GoodPupil(), new ExelentPupil());
            classRoom.Add(new Pupil("Медалист", "Лучший в классе по скорости чтения!", "Пишет иллиады!", "Успевает сделать все!"));
            foreach (Pupil pupil in classRoom.myClass)
            {
                pupil.Show();
            }
            Console.ReadKey();
        }
    }
}
