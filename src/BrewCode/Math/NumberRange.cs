using system;

namespace BrewCode.Math;

/// <summary>
/// NumberRange class containing a maximum and minimum of a type T.
/// </summary>
/// <typeparam name="T">Generic type parameter</typeparam>
public readonly record NumberRange<T> where T : IComparable<T>
{
    /// <summary>
    /// Minimum value of this range
    /// </summary>
    public readonly T Min { get; }

    /// <summary>
    /// Maximum value of this range
    /// </summary>
    public readonly T Max { get; }

    /// <summary>
    /// Creates a new NumberRange.
    /// </summary>
    /// <param name="min">Minimum value for this range, must be less than or equal to Maximum</param>
    /// <param name="max">Maximum value for this range, must be greater than or equal to the Minimum</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the minimum exceeds the maximum</exception>
    public NumberRange(T min, T max)
    {
        if (max < min)
        {
            throw new ArgumentOutOfRangeException("max cannot be less than min");
        }
        Min = min;
        Max = max;
    }

    public override string ToString()
    {
        return string.Format("{0} - {1}", Min, Max);
    }

    /// <summary>
    /// Checks if a value falls within the range, inclusively.
    /// </summary>
    /// <param name="value">value to compare</param>
    /// <returns>true if it falls within the range, false otherwise</returns>
    public bool ContainsValue(T value)
    {
        return value >= Min && value <= Max;
    }

    /// <summary>
    /// Tests if this range is within the bounds of another range.
    /// </summary>
    /// <param name="otherRange">The other range to test</param>
    /// <returns>true if this range is within the bounds of the other range</returns>
    public bool IsInRange(NumberRange<T> otherRange)
    {
        return otherRange.ContainsRange(this);
    }

    /// <summary>
    /// Tests if another range falls within the bounds of this range, inclusivley.
    /// </summary>
    /// <param name="otherRange">The other range to check</param>
    /// <returns>true if the other range falls within the bounds of this range, false otherwise</returns>
    public bool ContainsRange(NumberRange<T> otherRange)
    {
        return otherRange.Min >= this.Min && otherRange.Max <= this.Max;
    }

    /// <summary>
    /// Checks if only one bound of another range falls within this range, meaning they overlap but are not inclusive. 
    /// </summary>
    /// <param name="otherRange">other range to test</param>
    /// <returns>true if they overlap, but are not contained, false otherwise.</returns>
    public bool OverlapsRange(NumberRange<T> otherRange)
    {
        //check if either range is completely contained in the other
        if (this.ContainsRange(otherRange) || otherRange.ContainsRange(this))
            return false;

        //now if either min or max falls within our range, they do overlap
        return (this.ContainsValue(otherRange.Min)
            || (this.ContainsValue(otherRange.Max);
    }
    

}