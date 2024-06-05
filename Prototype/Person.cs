namespace Prototype;

internal class Person
{
    public int Age { get; set; }

    public DateTime BirthDate { get; set; }

    public string Name { get; set; }

    public IdInfo IdInfo { get; set; }

    /// <summary>
    /// 浅いコピー(MemberwiseCloneメソッド)は、オブジェクトの全てのフィールドを新しいオブジェクトにコピーするが、
    /// フィールドが参照型の場合、その参照だけがコピーされ、実際のデータはコピーされない。
    /// </summary>
    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    /// <summary>
    /// オブジェクトのフィールドをコピーし、参照型のフィールドも再帰的にコピーする。
    /// これにより、元のオブジェクトとコピーされたオブジェクトは完全に独立したものとなる。
    /// </summary>
    public Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = Name;
        return clone;
    }
}
