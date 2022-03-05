using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sierpinski_triangle
{
    class Sierpinski
    {
        private Queue<Triangle> queue;
        private List<Triangle> triangles;
        private Triangle original;
        private int triaglesDrawn;
        private int stopAt;
        public Sierpinski(Triangle T, int stopAt)
        {
            this.stopAt = stopAt;
            this.queue = new Queue<Triangle>();
            this.triangles = new List<Triangle>();
            this.triaglesDrawn = 0;
            original = T;
            SetUp();
        }
        public Sierpinski(PointF A, PointF B, PointF C, int stopAt)
        {
            this.stopAt = stopAt;
            this.queue = new Queue<Triangle>();
            this.triangles = new List<Triangle>();
            this.triaglesDrawn = 0;
            original = new Triangle(A, B, C);
            SetUp();
        }
        private void SetUp()
        {
            queue.Enqueue(original); // prvi trougao se ubacuje u red za rastavljanje
            while (queue.Count > 0) // dokle god ima truglova
                CalculateTriangle(queue.Dequeue()); // racunamo trougao i izbacujemo ga iz reda
        }
        private void CalculateTriangle(Triangle T)
        {
            if (Math.Sqrt(Math.Pow(T.A.X - T.B.X, 2) + Math.Pow(T.A.Y - T.B.Y, 2)) < stopAt) // ako je rastojanje izmedju tacaka manje od zadate zaustavlja se dalje rastavljanje trougla
                return;
            PointF A1 = new PointF((T.B.X + T.C.X) / 2, (T.B.Y + T.C.Y) / 2); // Srediste stranice BC
            PointF B1 = new PointF((T.A.X + T.C.X) / 2, (T.A.Y + T.C.Y) / 2); // Srediste stranice AC
            PointF C1 = new PointF((T.A.X + T.B.X) / 2, (T.A.Y + T.B.Y) / 2); // Srediste stranice AB
            triangles.Add(new Triangle(A1, B1, C1)); // dodajemo središnji kvadrat koji se uklanja
            Triangle left = new Triangle(T.A, C1, B1); // levi trougao koji treba da se rekurzivno podeli
            Triangle right = new Triangle(C1, T.B, A1); // desni trougao koji treba da se rekurzivno podeli
            Triangle top = new Triangle(B1, A1, T.C); // gornji trougao koji treba da se rekurzivno podeli
            /* truglovi se dodaju u redosled za racunanje */
            queue.Enqueue(left);
            queue.Enqueue(right);
            queue.Enqueue(top);
        }
        public void Draw(Graphics g, Color filledColor, Color removedColor)
        {
            SolidBrush fill = new SolidBrush(filledColor);
            SolidBrush remove = new SolidBrush(removedColor);
            g.FillPolygon(fill, original.toArray()); // crta veliki trougao
            for (int i = 0; i < triangles.Count; i++)
            {
                g.FillPolygon(remove, triangles[i].toArray()); // crta prazne trouglove
            }
        }
        public void DrawOriginal(Graphics g, Color filledColor) // samo veliki
        {
            SolidBrush fill = new SolidBrush(filledColor);
            g.FillPolygon(fill, original.toArray());
        }
        public void DrawEmpty(Graphics g, Color removedColor) // jedan prazan
        {
            if (triaglesDrawn == triangles.Count) return;
            SolidBrush remove = new SolidBrush(removedColor);
            g.FillPolygon(remove, triangles[triaglesDrawn++].toArray());
        }
        public void Reset() 
        {
            this.triaglesDrawn = 0;
        }
        public bool End() { return this.triaglesDrawn == this.triangles.Count; }
    }
}
