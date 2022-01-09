public class Vector2
{
    // Properties
    public double x { get; set; }
    public double y { get; set; }

    public double magnitude
    {
        get
        {
            double sql = this.x * this.x + this.y * this.y;
            double len = Math.Sqrt(sql);
            return len;
        }
    }

    public double sqrMagnitude
    {
        get
        {
            double sql = this.x * this.x + this.y * this.y;
            return sql;
        }
    }

    public Vector2 normalized
    {
        get
        {
            double len = this.magnitude;
            if (len <= 0)
            {
                return Vector2.zero;
            }
            double x = this.x / len;
            double y = this.y / len;
            return new Vector2(x, y);
        }

    }

    // Indexer
    public double this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return this.x;
                case 1: return this.y;
                default: throw new Exception("Invalid Index - Index In Vector3 Must Range Between 0 And 2");
            }
        }
        set
        {
            if (i == 0)
            {
                this.x = value;
            }
            else if (i == 1)
            {
                this.y = value;
            }
            else
            {
                throw new Exception("Invalid Index - Index In Vector3 Must Range Between 0 And 2");
            }
        }
    }

    // Static Properties
    public static Vector2 zero
    {
        get => new Vector2(0, 0);
    }

    public static Vector2 one
    {
        get => new Vector2(1, 1);
    }

    public static Vector2 left
    {
        get => new Vector2(-1, 0);
    }

    public static Vector2 right
    {
        get => new Vector2(1, 0);
    }

    public static Vector2 up
    {
        get => new Vector2(0, 1);
    }

    public static Vector2 down
    {
        get => new Vector2(0, -1);
    }

    // Constructors
    public Vector2(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2()
    {
        this.x = 0;
        this.y = 0;
    }

    public Vector2(Vector2 other)
    {
        this.x = other.x;
        this.y = other.y;
    }

    //Methods

    public void Reverse()
    {
        this.x = -this.x;
        this.y = -this.y;
    }

    public bool Normalize()
    {
        double len = this.magnitude;
        if (len <= 0)
        {
            return false;
        }
        this.x /= len;
        this.y /= len;
        return true;
    }

    // Static methods
    public static double Dot(Vector2 a, Vector2 b)
    {
        return a.x * b.x + a.y * b.y;
    }

    public static double Distance(Vector2 a, Vector2 b)
    {
        return (a - b).magnitude;
    }

    // Operator overloads
    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        double newX = a.x + b.x;
        double newY = a.y + b.y;
        Vector2 v = new Vector2(newX, newY);
        return v;
    }

    public static Vector2 operator -(Vector2 a, Vector2 b)
    {
        double newX = a.x - b.x;
        double newY = a.y - b.y;
        Vector2 v = new Vector2(newX, newY);
        return v;
    }

    public static Vector2 operator *(Vector2 a, Vector2 b)
    {
        double newX = a.x * b.x;
        double newY = a.y * b.y;
        Vector2 v = new Vector2(newX, newY);
        return v;
    }

    public static Vector2 operator *(Vector2 a, double b)
    {
        double newX = a.x * b;
        double newY = a.y * b;
        Vector2 v = new Vector2(newX, newY);
        return v;
    }

    public static Vector2 operator /(Vector2 a, Vector2 b)
    {
        double newX = a.x / b.x;
        double newY = a.y / b.y;
        Vector2 v = new Vector2(newX, newY);
        return v;
    }

    public static Vector2 operator /(Vector2 a, double b)
    {
        double newX = a.x / b;
        double newY = a.y / b;
        Vector2 v = new Vector2(newX, newY);
        return v;
    }

    // Overides
    public override string ToString()
    {
        return $"[{this.x}, {this.y}]";
    }
}

public class Vector3
{
    // Properties
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }

    public double magnitude
    {
        get
        {
            double sql = this.x * this.x + this.y * this.y + this.z * this.z;
            double len = Math.Sqrt(sql);
            return len;
        }
    }

    public double sqrMagnitude
    {
        get
        {
            double sql = this.x * this.x + this.y * this.y + this.z * this.z;
            return sql;
        }
    }

    public Vector3 normalized
    {
        get
        {
            double len = this.magnitude;
            if (len <= 0)
            {
                return Vector3.zero;
            }
            double x = this.x / len;
            double y = this.y / len;
            double z = this.z / len;
            return new Vector3(x, y, z);
        }

    }

    //static properties
    public static Vector3 zero
    {
        get => new Vector3(0, 0, 0);
    }

    public static Vector3 one
    {
        get => new Vector3(1, 1, 1);
    }

    public static Vector3 left
    {
        get => new Vector3(-1, 0, 0);
    }

    public static Vector3 right
    {
        get => new Vector3(1, 0, 0);
    }

    public static Vector3 up
    {
        get => new Vector3(0, 1, 0);
    }

    public static Vector3 down
    {
        get => new Vector3(0, -1, 0);
    }

    public static Vector3 forward
    {
        get => new Vector3(0, 0, 1);
    }

    public static Vector3 back
    {
        get => new Vector3(0, 0, -1);
    }

    // Indexer
    public double this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return this.x;
                case 1: return this.y;
                case 2: return this.z;
                default: throw new Exception("Invalid Index - Index In Vector3 Must Range Between 0 And 2");
            }
        }
        set
        {
            if (i == 0)
            {
                this.x = value;
            }
            else if (i == 1)
            {
                this.y = value;
            }
            else if (i == 2)
            {
                this.z = value;
            }
            else
            {
                throw new Exception("Invalid Index - Index In Vector3 Must Range Between 0 And 2");
            }
        }
    }

    // Constructors
    public Vector3(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3()
    {
        this.x = 0;
        this.y = 0;
        this.z = 0;
    }

    public Vector3(Vector3 other)
    {
        this.x = other.x;
        this.y = other.y;
        this.z = other.z;
    }

    //Methods  
    public void Reverse()
    {
        this.x = -this.x;
        this.y = -this.y;
        this.z = -this.z;
    }

    public bool Normalize()
    {
        double len = this.magnitude;
        if (len <= 0)
        {
            return false;
        }
        this.x /= len;
        this.y /= len;
        this.z /= len;
        return true;
    }
    // Static methods

    public static double Dot(Vector3 a, Vector3 b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    public static Vector3 Cross(Vector3 a, Vector3 b)
    {
        double x = a.y * b.z - a.z * b.y;
        double y = a.z * b.x - a.x * b.z;
        double z = a.x * b.y - a.y * b.x;
        return new Vector3(x, y, z);
    }

    public static double Distance(Vector3 a, Vector3 b)
    {
        return (a - b).magnitude;
    }

    // Operator overloads
    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        double newX = a.x + b.x;
        double newY = a.y + b.y;
        double newZ = a.z + b.z;
        Vector3 v = new Vector3(newX, newY, newZ);
        return v;
    }

    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        double newX = a.x - b.x;
        double newY = a.y - b.y;
        double newZ = a.z - b.z;
        Vector3 v = new Vector3(newX, newY, newZ);
        return v;
    }

    public static Vector3 operator *(Vector3 a, Vector3 b)
    {
        double newX = a.x * b.x;
        double newY = a.y * b.y;
        double newZ = a.z * b.z;
        Vector3 v = new Vector3(newX, newY, newZ);
        return v;
    }

    public static Vector3 operator *(Vector3 a, double b)
    {
        double newX = a.x * b;
        double newY = a.y * b;
        double newZ = a.z * b;
        Vector3 v = new Vector3(newX, newY, newZ);
        return v;
    }

    public static Vector3 operator /(Vector3 a, Vector3 b)
    {
        double newX = a.x / b.x;
        double newY = a.y / b.y;
        double newZ = a.z / b.z;
        Vector3 v = new Vector3(newX, newY, newZ);
        return v;
    }

    public static Vector3 operator /(Vector3 a, double b)
    {
        double newX = a.x / b;
        double newY = a.y / b;
        double newZ = a.z / b;
        Vector3 v = new Vector3(newX, newY, newZ);
        return v;
    }


    // Overides
    public override string ToString()
    {
        return $"[{this.x}, {this.y}, {this.z}]";
    }
}
