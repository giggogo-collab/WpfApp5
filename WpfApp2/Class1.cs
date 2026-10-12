using System;

namespace Lib_2
{
    /// <summary>
    /// Класс "Пара чисел"
    /// </summary>
    public class Pair
    {
        private int _pervoe;
        private int _vtoroe;

        public int Pervoe
        {
            get { return _pervoe; }
            set { _pervoe = value; }
        }

        public int Vtoroe
        {
            get { return _vtoroe; }
            set { _vtoroe = value; }
        }

        public Pair()
        {
            _pervoe = 0;
            _vtoroe = 0;
        }

        public Pair(int pervoe, int vtoroe)
        {
            _pervoe = pervoe;
            _vtoroe = vtoroe;
        }

        /// <summary>
        /// Метод сложения полей пары 
        /// </summary>
        /// <returns>Сумма полей</returns>
        public int Summa()
        {
            return _pervoe + _vtoroe;
        }

        /// <summary>
        /// Операция сложения двух пар: (a,b) + (c,d) = (a+c, b+d)
        /// </summary>
        public static Pair operator +(Pair p1, Pair p2)
        {
            return new Pair(p1.Pervoe + p2.Pervoe, p1.Vtoroe + p2.Vtoroe);
        }

        /// <summary>
        /// Перегруженный метод: увеличить поля на 1
        /// </summary>
        public void Yvelech_1()
        {
            _pervoe = _pervoe + 1;
            _vtoroe = _vtoroe + 1;
        }

        /// <summary>
        /// Перегруженный метод: увеличить поля на заданное число
        /// </summary>
        public void Yvelich_pola(int value)
        {
            _pervoe = _pervoe + value;
            _vtoroe = _vtoroe + value;
        }

        /// <summary>
        /// Перегруженный метод: уменьшить поля на 1
        /// </summary>
          public void Ymenshit_1()
          {
            _pervoe = _pervoe - 1;
            _vtoroe = _vtoroe - 1;
          }

        /// <summary>
        /// Перегруженный метод: уменьшить поля на заданное число
        /// </summary>
        public void Ymenshit_pola(int value)
        {
            _pervoe = _pervoe - value;
            _vtoroe = _vtoroe - value;
        }

        /// <summary>
        /// Перегруженный метод: сложение трёх пар
        /// </summary>
        public static Pair Summatreh(Pair p1, Pair p2, Pair p3)
        {
            return new Pair(
                p1.Pervoe + p2.Pervoe + p3.Pervoe,
                p1.Vtoroe + p2.Vtoroe + p3.Vtoroe);
        }

        /// <summary>
        /// Формирование строки информации о паре
        /// </summary>
        public override string ToString()
        {
            return "(" + _pervoe + "; " + _vtoroe + ")";
        }
    }
}
