using System;

namespace T14
{
    [DeveloperInfo("Poletaev Nikita", "16.12.2022")]
    public class RationalNumber
    {
        public int chisl { get; set; }
        private int znam;
        public int SetZnam
        {
            get { return znam; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    znam = value;
                }
            }
        }
        public RationalNumber(int Chisl, int Bottom)
        {
            this.chisl = Chisl;
            this.SetZnam = Bottom;
        }
        public RationalNumber()
        {
        }
        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            if ((double)r1.chisl / r1.SetZnam == (double)r2.chisl / r2.SetZnam)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            if ((double)r1.chisl / r1.SetZnam == (double)r2.chisl / r2.SetZnam)
            {
                return false;
            }
            return true;
        }
        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            if ((double)r1.chisl / r1.SetZnam > (double)r2.chisl / r2.SetZnam)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            if ((double)r1.chisl / r1.SetZnam < (double)r2.chisl / r2.SetZnam)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            if ((double)r1.chisl / r1.SetZnam >= (double)r2.chisl / r2.SetZnam)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            if ((double)r1.chisl / r1.SetZnam <= (double)r2.chisl / r2.SetZnam)
            {
                return true;
            }
            return false;
        }
        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber r3 = new RationalNumber();
            r3.chisl = r1.chisl * r2.SetZnam + r2.chisl * r1.SetZnam;
            r3.SetZnam = r1.SetZnam * r2.SetZnam;
            return r3;
        }
        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            RationalNumber r3 = new RationalNumber();
            r3.chisl = r1.chisl * r2.SetZnam - r2.chisl * r1.SetZnam;
            r3.SetZnam = r1.SetZnam * r2.SetZnam;
            return r3;
        }

        public static RationalNumber operator ++(RationalNumber r1)
        {
            return new RationalNumber(r1.chisl + 1, r1.SetZnam);
        }
        public static RationalNumber operator --(RationalNumber r1)
        {
            return new RationalNumber(r1.chisl - 1, r1.SetZnam);
        }
        public static implicit operator RationalNumber(int x)
        {
            return new RationalNumber(x, 1);
        }
        public static explicit operator double(RationalNumber r)
        {
            return (double)r.chisl / r.SetZnam;
        }
        public override string ToString()
        {
            return $"{chisl}/{SetZnam}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNumber r1)
            {
                return r1 == this;
            }
            return base.Equals(obj);
        }
    }
}