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
            switch (len)
            {
                case <= 0: return Vector2.zero;
                case >= double.PositiveInfinity: return Vector2.one;
                default:
                    double x = this.x / len;
                    double y = this.y / len;
                    return new Vector2(x, y);
            }
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

    public static Vector2 positiveInfinity
    {
        get => new Vector2(double.PositiveInfinity, double.PositiveInfinity);
    }

    public static Vector2 negativeInfinity
    {
        get => new Vector2(double.NegativeInfinity, double.NegativeInfinity);
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
        switch (len)
        {
            case <= 0: return false;
            case >= double.PositiveInfinity: return false;
            default:
                this.x /= len;
                this.y /= len;
                return true;
        }
    }

    public void Set(double x, double y)
    {
        this.x = x;
        this.y = y;
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

    public override bool Equals(object? other)
    {
        Vector2? otherVector2 = other as Vector2;

        if (otherVector2 == null)
            return false;

        return this.x == otherVector2.x && this.y == otherVector2.y;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            // Suitable nullity checks etc, of course :)
            hash = hash * 23 + this.x.GetHashCode();
            hash = hash * 23 + this.y.GetHashCode();
            return hash;
        }

    }
}

public class Vector2Int
{
    // Properties
    public int x { get; set; }
    public int y { get; set; }

    public double magnitude
    {
        get
        {
            double sql = this.x * this.x + this.y * this.y;
            double len = Math.Sqrt(sql);
            return len;
        }
    }

    public int sqrMagnitude
    {
        get
        {
            int sql = this.x * this.x + this.y * this.y;
            return sql;
        }
    }

    // Indexer
    public int this[int i]
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
    public static Vector2Int zero
    {
        get => new Vector2Int(0, 0);
    }

    public static Vector2Int one
    {
        get => new Vector2Int(1, 1);
    }

    public static Vector2Int left
    {
        get => new Vector2Int(-1, 0);
    }

    public static Vector2Int right
    {
        get => new Vector2Int(1, 0);
    }

    public static Vector2Int up
    {
        get => new Vector2Int(0, 1);
    }

    public static Vector2Int down
    {
        get => new Vector2Int(0, -1);
    }

    // Constructors
    public Vector2Int(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2Int()
    {
        this.x = 0;
        this.y = 0;
    }

    public Vector2Int(Vector2Int other)
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

    public void Set(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Static methods
    public static double Distance(Vector2 a, Vector2 b)
    {
        return (a - b).magnitude;
    }

    // Operator overloads
    public static Vector2Int operator +(Vector2Int a, Vector2Int b)
    {
        int newX = a.x + b.x;
        int newY = a.y + b.y;
        Vector2Int v = new Vector2Int(newX, newY);
        return v;
    }

    public static Vector2Int operator -(Vector2Int a, Vector2Int b)
    {
        int newX = a.x - b.x;
        int newY = a.y - b.y;
        Vector2Int v = new Vector2Int(newX, newY);
        return v;
    }

    public static Vector2Int operator *(Vector2Int a, Vector2Int b)
    {
        int newX = a.x * b.x;
        int newY = a.y * b.y;
        Vector2Int v = new Vector2Int(newX, newY);
        return v;
    }

    public static Vector2Int operator *(Vector2Int a, int b)
    {
        int newX = a.x * b;
        int newY = a.y * b;
        Vector2Int v = new Vector2Int(newX, newY);
        return v;
    }

    public static Vector2Int operator /(Vector2Int a, Vector2Int b)
    {
        int newX = a.x / b.x;
        int newY = a.y / b.y;
        Vector2Int v = new Vector2Int(newX, newY);
        return v;
    }

    public static Vector2Int operator /(Vector2Int a, int b)
    {
        int newX = a.x / b;
        int newY = a.y / b;
        Vector2Int v = new Vector2Int(newX, newY);
        return v;
    }

    // Overides
    public override string ToString()
    {
        return $"[{this.x}, {this.y}]";
    }

    public override bool Equals(object? other)
    {
        Vector2Int? otherVector2 = other as Vector2Int;

        if (otherVector2 == null)
            return false;

        return this.x == otherVector2.x && this.y == otherVector2.y;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            // Suitable nullity checks etc, of course :)
            hash = hash * 23 + this.x.GetHashCode();
            hash = hash * 23 + this.y.GetHashCode();
            return hash;
        }

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
            switch (len)
            {
                case <= 0: return Vector3.zero;
                case >= double.PositiveInfinity: return Vector3.one;
                default:
                    double x = this.x / len;
                    double y = this.y / len;
                    double z = this.z / len;
                    return new Vector3(x, y, z);
            }


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

    public static Vector3 positiveInfinity
    {
        get => new Vector3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);
    }

    public static Vector3 negativeInfinity
    {
        get => new Vector3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
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
        switch (len)
        {
            case <= 0: return false;
            case >= double.PositiveInfinity: return false;
            default:
                this.x /= len;
                this.y /= len;
                this.z /= len;
                return true;
        }
    }

    public void Set(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
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

    public static bool WithinBounds(Vector3 a, Vector3 b, Vector3 c)
    {
        if ((a.x >= b.x && a.x <= c.x) && (a.y >= b.y && a.y <= c.y) && (a.z >= b.z && a.z <= c.z)) return true;
        return false;
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

    public override bool Equals(object? other)
    {
        Vector3? otherVector3 = other as Vector3;

        if (otherVector3 == null)
            return false;

        return this.x == otherVector3.x && this.y == otherVector3.y && this.z == otherVector3.z;
    }

    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            int hash = 17;
            // Suitable nullity checks etc, of course :)
            hash = hash * 23 + this.x.GetHashCode();
            hash = hash * 23 + this.y.GetHashCode();
            hash = hash * 23 + this.z.GetHashCode();
            return hash;
        }
    }
}

public class Vector3Int
{
    // Properties
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    public double magnitude
    {
        get
        {
            double sql = this.x * this.x + this.y * this.y + this.z * this.z;
            double len = Math.Sqrt(sql);
            return len;
        }
    }

    public int sqrMagnitude
    {
        get
        {
            int sql = this.x * this.x + this.y * this.y + this.z * this.z;
            return sql;
        }
    }

    //static properties
    public static Vector3Int zero
    {
        get => new Vector3Int(0, 0, 0);
    }

    public static Vector3Int one
    {
        get => new Vector3Int(1, 1, 1);
    }

    public static Vector3Int left
    {
        get => new Vector3Int(-1, 0, 0);
    }

    public static Vector3Int right
    {
        get => new Vector3Int(1, 0, 0);
    }

    public static Vector3Int up
    {
        get => new Vector3Int(0, 1, 0);
    }

    public static Vector3Int down
    {
        get => new Vector3Int(0, -1, 0);
    }

    public static Vector3Int forward
    {
        get => new Vector3Int(0, 0, 1);
    }

    public static Vector3Int back
    {
        get => new Vector3Int(0, 0, -1);
    }

    // Indexer
    public int this[int i]
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
    public Vector3Int(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3Int()
    {
        this.x = 0;
        this.y = 0;
        this.z = 0;
    }

    public Vector3Int(Vector3Int other)
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

    public void Set(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Static methods

    public static int Dot(Vector3Int a, Vector3Int b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    public static double Distance(Vector3 a, Vector3 b)
    {
        return (a - b).magnitude;
    }

    public static bool WithinBounds(Vector3Int a, Vector3Int b, Vector3Int c)
    {
        if ((a.x >= b.x && a.x <= c.x) && (a.y >= b.y && a.y <= c.y) && (a.z >= b.z && a.z <= c.z)) return true;
        return false;
    }

    // Operator overloads
    public static Vector3Int operator +(Vector3Int a, Vector3Int b)
    {
        int newX = a.x + b.x;
        int newY = a.y + b.y;
        int newZ = a.z + b.z;
        Vector3Int v = new Vector3Int(newX, newY, newZ);
        return v;
    }

    public static Vector3Int operator -(Vector3Int a, Vector3Int b)
    {
        int newX = a.x - b.x;
        int newY = a.y - b.y;
        int newZ = a.z - b.z;
        Vector3Int v = new Vector3Int(newX, newY, newZ);
        return v;
    }

    public static Vector3Int operator *(Vector3Int a, Vector3Int b)
    {
        int newX = a.x * b.x;
        int newY = a.y * b.y;
        int newZ = a.z * b.z;
        Vector3Int v = new Vector3Int(newX, newY, newZ);
        return v;
    }

    public static Vector3Int operator *(Vector3Int a, int b)
    {
        int newX = a.x * b;
        int newY = a.y * b;
        int newZ = a.z * b;
        Vector3Int v = new Vector3Int(newX, newY, newZ);
        return v;
    }

    public static Vector3Int operator /(Vector3Int a, Vector3Int b)
    {
        int newX = a.x / b.x;
        int newY = a.y / b.y;
        int newZ = a.z / b.z;
        Vector3Int v = new Vector3Int(newX, newY, newZ);
        return v;
    }

    public static Vector3Int operator /(Vector3Int a, int b)
    {
        int newX = a.x / b;
        int newY = a.y / b;
        int newZ = a.z / b;
        Vector3Int v = new Vector3Int(newX, newY, newZ);
        return v;
    }

    // Overides
    public override string ToString()
    {
        return $"[{this.x}, {this.y}, {this.z}]";
    }

    public override bool Equals(object? other)
    {
        Vector3Int? otherVector3 = other as Vector3Int;

        if (otherVector3 == null)
            return false;

        return this.x == otherVector3.x && this.y == otherVector3.y && this.z == otherVector3.z;
    }

    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            int hash = 17;
            // Suitable nullity checks etc, of course :)
            hash = hash * 23 + this.x.GetHashCode();
            hash = hash * 23 + this.y.GetHashCode();
            hash = hash * 23 + this.z.GetHashCode();
            return hash;
        }
    }
}

