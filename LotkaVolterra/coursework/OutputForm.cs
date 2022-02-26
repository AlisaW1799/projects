using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace coursework
{
    public partial class OutputForm : Form
    {
        const double MARGIN = 40.0;

        public OutputForm()
        {
            InitializeComponent();
        }

        private GraphSelect graph;
        private List<TheData> data;
        private List<List<TheData>> circleData;
        private double maxX;
        private double maxY;
        private double marginGlX;
        private double marginGlY;

        public void load()
        {
            prepare();
            ant.InitializeContexts();
            reshape();
            PointInGrap.Start();
        }

        private void prepare()
        {
            this.graph = Lotka.Inst.graph;
            if (graph == GraphSelect.Lotka)
            {
                data = Lotka.Inst.getData();
                maxX = data.Max(el => el.t);
                maxY = data.Max(el => Math.Max(el.x, el.y));
            }
            else
            {
                circleData = Lotka.Inst.getCircleData();
                maxX = maxY = 0;
                foreach (var oneData in circleData)
                {
                    var curX = oneData.Max(el => el.x);
                    var curY = oneData.Max(el => el.y);
                    if (curX > maxX)
                    {
                        maxX = curX;
                    }
                    if (curY > maxY)
                    {
                        maxY = curY;
                    }
                }
            }
        }

        private void reshape()
        {
            Gl.glClearColor(255, 225, 255, 1);
            Gl.glViewport(0, 0, ant.Width, ant.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            marginGlX = MARGIN * maxX / (ant.Width - MARGIN * 2);
            marginGlY = MARGIN * maxY / (ant.Height - MARGIN * 2);
            Glu.gluOrtho2D(-marginGlX, maxX + marginGlX, -marginGlY, maxY + marginGlY);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }

        private void PointInGrap_Tick(object sender, EventArgs e)
        {
            Draw();                                                                                             //функция визуализации
        }

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();                                                                                // очищение текущей матрицы
            Gl.glColor3f(0, 0, 0);

            // Координатная сетка
            Gl.glBegin(Gl.GL_POINTS);
            for (int ax = 1; ax <= maxX; ax++)
            {
                for (int bx = 1; bx <= maxY; bx++)
                {
                    Gl.glVertex2d(ax, bx);
                }
            }
            Gl.glEnd();
            
            // Оси
            Gl.glBegin(Gl.GL_LINES); 

            // Настройки
            double stepAlong = 0.5;
            double stepAcross = 0.2;

            // Вертикальная ось
            Gl.glColor3f(0, 0, 0);
            Gl.glVertex2d(0, 0);                                                                       // далее мы рисуем координатные оси и стрелки на их концах
            Gl.glVertex2d(0, maxY);

            Gl.glVertex2d(0, maxY);                                                                   // вертикальная стрелка
            Gl.glVertex2d(stepAcross * marginGlX, maxY - stepAlong * marginGlY);
            Gl.glVertex2d(0, maxY);
            Gl.glVertex2d(-stepAcross * marginGlX, maxY - stepAlong * marginGlY);

            // Горизонтальная ось
            Gl.glVertex2d(0, 0);
            Gl.glVertex2d(maxX, 0);

            Gl.glVertex2d(maxX, 0);                                                                   // горизонтальная стрелка
            Gl.glVertex2d(maxX - stepAlong * marginGlX, stepAcross * marginGlY);
            Gl.glVertex2d(maxX, 0);
            Gl.glVertex2d(maxX - stepAlong * marginGlX, -stepAcross * marginGlY);

            Gl.glEnd();

            // Числа на горизонтальной оси
            for (int i = 0; i < maxX; i += 4)
            {
                 PrintText2D(i, -marginGlY * 0.4, i.ToString());
            }

            // Числа на вертикальной оси
            for (int i = 4; i < maxY; i += 4)
            {
                 PrintText2D(-marginGlX * 0.7, i - marginGlY/20.0*3.0, i.ToString());
            }

            // Подписи осей
            if (Lotka.Inst.graph == GraphSelect.Lotka)
            {
                PrintText2D(maxX - marginGlX * 0.8, -0.7 * marginGlY, "Time");
                PrintText2D(-0.2 * marginGlX, maxY + 0.4 * marginGlY, "Population");
            }
            else
            {
                PrintText2D(maxX - marginGlX * 1.0, -0.7 * marginGlY, "Preys");
                PrintText2D(-0.2 * marginGlX, maxY + 0.4 * marginGlY, "Predators");
            }

            // Кривые
            DrawDiagram();

            // дожидаемся завершения визуализации кадра 
            Gl.glFlush();
            ant.Invalidate();                                                                                   // сигнал для обновление элемента реализующего визуализацию
        }

        private void DrawDiagram()
        {
            if (graph == GraphSelect.Lotka)
            {
                // Жертвы
                Gl.glBegin(Gl.GL_LINE_STRIP);                                                                       //стартуем отрисовку в режиме визуализации точек объединяемых в линии
                Gl.glColor3f(0, 0, 225);
                for (int i = 0; i < data.Count; i++)
                {
                    Gl.glVertex2d(data[i].t, data[i].x);
                }
                Gl.glEnd();

                // Хищники
                Gl.glBegin(Gl.GL_LINE_STRIP);                                                                       //стартуем отрисовку в режиме визуализации точек объединяемых в линии
                Gl.glColor3f(255, 0, 0);
                for (int i = 0; i < data.Count; i++)
                {
                    // передаем в OpenGL информацию о вершине, участвующей в построении линий
                    Gl.glVertex2d(data[i].t, data[i].y);
                }
                Gl.glEnd();
            }
            else
            {
                // Центральная точка
                if (circleData.Count > 0 && circleData[0].Count > 0)
                {
                    Gl.glPointSize(5.0f);
                    Gl.glBegin(Gl.GL_POINTS);
                    Gl.glColor3f(255, 0, 0);
                    Gl.glVertex2d(circleData[0][0].x, circleData[0][0].y);
                    Gl.glEnd();
                    Gl.glPointSize(1.0f);
                }
                // Круги
                for (int k = 1; k < circleData.Count; k++)
                {
                    Gl.glBegin(Gl.GL_LINE_STRIP);
                    var oneData = circleData[k];
                    for (int i = 0; i < oneData.Count; i++)
                    {
                        // передаем в OpenGL информацию о вершине, участвующей в построении линий
                        Gl.glVertex2d(oneData[i].x, oneData[i].y);
                    }
                    Gl.glEnd();
                }
            }
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glEnd();
        }

        private void PrintText2D(double x, double y, string text)
        {
            Gl.glRasterPos2f((float)x, (float)y);
            foreach (char draw in text)
            {
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_8_BY_13, draw);
            }
        }

        private void output_FormClosing(object sender, FormClosingEventArgs e)
        {
            PointInGrap.Stop();
            this.Hide();
            InputForm.thisForm.Show();
        }

        private void output_SizeChanged(object sender, EventArgs e)
        {
            reshape();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputForm.thisForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
