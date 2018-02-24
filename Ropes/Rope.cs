﻿using System;
using System.Collections;
using System.Runtime.Serialization;

public interface Rope : ISerializable, IEnumerable, IComparable
{
	/// <summary>
	/// Returns a new rope created by appending the specified character to this rope
	/// </summary>
	/// <param name="c">the specified character</param>
	/// <returns>a new rope</returns>
	Rope Append(char c);

	/// <summary>
	/// Returns a new rope created by appending the specified character sequence to
	/// this rope
	/// </summary>
	/// <param name="suffix">the sequence to append</param>
	/// <returns>a new rope</returns>
	Rope Append(String suffix);

	/// <summary>
	/// Returns a new rope created by appending the specified character range to
	/// this rope
	/// </summary>
	/// <param name="csq">the specified character</param>
	/// <param name="start">the start index, inclusive</param>
	/// <param name="end">the end index, non-inclusive</param>
	/// <returns>a new rope</returns>
	Rope Append(String csq, int start, int end);

	/// <summary>
	/// Creats a new rope by delete the specified character substring.
	/// The substring begins at the specified<code>start</code> and extends to
	/// the character at index <code>end - 1</code> or to the end of the
	/// sequence if no such character exists. If
	/// start is equal to end, no changes are made.
	/// </summary>
	/// <param name="start">the beginning index, inclusive</param>
	/// <param name="end">the ending index, inclusive</param>
	/// <returns>this rope</returns>
	Rope Delete(int start, int end);

	/// <summary>
	/// Returns the index within this rope of the first occurrence of the
	/// specified character. If a character with value ch occurs in the 
	/// character sequence represented by this Rope object, then the index
	/// of the first such occurrence is returned - that is, the smallest k
	/// such that this.charAt(k) == ch is true. If no such character occurs
	/// in this string, then -1 is returned.
	/// </summary>
	/// <param name="ch">a character</param>
	/// <returns>index of the first occurrence of the character within this
	/// object or -1 if the character does not occur</returns>
	int IndexOf(char ch);

	/// <summary>
	/// Returns the index within this rope of the first occurrence of the
	/// specified character, beginning at the specified index. If a character
	/// with value ch occurs in the character sequence represented by this 
	/// Rope object, then the index of the first such occurrence is returned - 
	/// that is, the smallest k such that this.charAt(k) == ch is true. If no
	/// such character occurs in this string, then -1 is returned.
	/// </summary>
	/// <param name="ch">a character</param>
	/// <param name="fromIndex">the index to start searching from</param>
	/// <returns>index of the character if found, else -1</returns>
	int IndexOf(char ch, int fromIndex);

	/// <summary>
	/// Returns the index within this rope of the first occurrence of the
	/// specified string. The value returned is the smallest k such that
	/// this.StartsWith(str, k) is true. If no such character occurs
	/// in this string, then -1 is returned.
	/// </summary>
	/// <param name="sequence">sequence to find</param>
	/// <returns>index of the sequence if found, else -1</returns>
	int IndexOf(String sequence);

	/// <summary>
	/// Returns the index within this rope of the first occurrence of the
	/// specified string starting from the specified index. The value 
	/// returned is the smallest k such that this.StartsWith(str, k) is true. 
	/// If no such character occurs in this string, then -1 is returned.
	/// </summary>
	/// <param name="sequence">sequence to find</param>
	/// <param name="fromIndex">the index to start searching</param>
	/// <returns>the index if found, else -1</returns>
	int IndexOf(String sequence, int fromIndex);

	/// <summary>
	/// Creates a new rope by inserting the specified string into this 
	/// rope. The characters of the string are inserted in order into 
	/// this rope at the indicated offset. If s is null, then the four 
	/// characters "null" are inserted into this sequence
	/// </summary>
	/// <param name="dstOffset">the offset</param>
	/// <param name="s">the sequence to be inserted</param>
	/// <returns>a new rope</returns>
	Rope Insert(int dstOffset, String s);

	/// <summary>
	/// Returns an IEnumerator positioned to start at the specified index.
	/// </summary>
	/// <param name="start">the start position</param>
	/// <returns>an IEnumerator which starts at the specified index</returns>
	IEnumerator Iterator(int start);

	/// <summary>
	/// Trims all whitespace from the beginning of this string
	/// </summary>
	/// <returns>a rope with all leading whitespace trimmed</returns>
	Rope TrimStart();

	/// <summary>
	/// Returns true if this rope matches the specified regex pattern, 
	/// otherwise false.
	/// </summary>
	/// <param name="regex">the regular expression</param>
	/// <returns>true if this rope matches the pattern, otherwise false</returns>
	bool FMatches(String regex);

	/// <summary>
	/// Rebalances the current rope, returning the rebalance rope. In general,
	/// rope rebalancing is handled automatically, but this method is provided
	/// to give users more control
	/// </summary>
	/// <returns>a rebalanced rope</returns>
	Rope Rebalance();

	/// <summary>
	/// Reverses this rope
	/// </summary>
	/// <returns>a reversed copy of this rope</returns>
	Rope Reverse();

	/// <summary>
	/// Returns an IEnumerator positioned to start at the end of this rope and
	/// go toward the beginning
	/// </summary>
	/// <returns>a reverse enumerator</returns>
	IEnumerator ReverseEnumerator();

	/// <summary>
	/// Returns an IEnumerator positioned to start at the specified index and move
	/// backwards through a rope.
	/// </summary>
	/// <param name="start">the starting position</param>
	/// <returns>a reverse IEnumerator</returns>
	IEnumerator ReverseIterator(int start);

	/// <summary>
	/// Trims all whitespace from the end of this rope
	/// </summary>
	/// <returns>a rope with all trailing whitespace removed</returns>
	Rope TrimEnd();

	/// <summary>
	/// Returns a new rope denoting the subsequence from position start to 
	/// position end.
	/// </summary>
	/// <param name="start">the starting position</param>
	/// <param name="end">end ending position</param>
	/// <returns>a new rope denoting the subsequence</returns>
	Rope SubSequence(int start, int end);

	/// <summary>
	/// Trims all whitespace from the beginning and end of this rope
	/// </summary>
	/// <returns>a whitespace-trimmed rope</returns>
	Rope Trim();

	/// <summary>
	/// Increase the length of this rope to the specified length by prepending
	/// spaces to this rope. If the specified length is less than or equal to
	/// the current length, the rope is unchanged. 
	/// </summary>
	/// <param name="toLength">the desired length</param>
	/// <returns>the padded rope</returns>
	Rope PadStart(int toLength);

	/// <summary>
	/// Increase the length of this rope to the specified length by repeatedly
	/// prepending the character to it. If the specified length is less than or 
	/// equal to the current length, the rope is unchanged. 
	/// </summary>
	/// <param name="toLength">the desired length</param>
	/// <param name="padChar">the character to use for padding</param>
	/// <returns>the padded rope</returns>
	Rope PadStart(int toLength, char padChar);

	/// <summary>
	/// Increase the length of this rope to the specified length by appending
	/// spaces to this rope. If the specified length is less than or equal to
	/// the current length, the rope is unchanged. 
	/// </summary>
	/// <param name="toLength">the desired length</param>
	/// <returns>the padded rope</returns>
	Rope PadEnd(int toLength);

	/// <summary>
	/// Increase the length of this rope to the specified length by repeatedly
	/// appending the character to it. If the specified length is less than or 
	/// equal to the current length, the rope is unchanged. 
	/// </summary>
	/// <param name="toLength">the desired length</param>
	/// <param name="padChar">the character to use for padding</param>
	/// <returns>the padded rope</returns>
	Rope PadEnd(int toLength, char padChar);

	/// <summary>
	/// Tells whether the length of the rope is zero. 
	/// </summary>
	/// <returns>true if the length is zero, else false</returns>
	bool FEmpty();

	/// <summary>
	/// Tells whether the rope starts with the specified prefix
	/// </summary>
	/// <param name="prefix">the specified prefix</param>
	/// <returns>true if it starts with the prefix, else false</returns>
	bool StartsWith(String prefix);

	/// <summary>
	/// Tells whether the rope starts with the specified prefix offset by a
	/// given number of characters
	/// </summary>
	/// <param name="prefix">the specified prefix</param>
	/// <param name="offset">the specified offset</param>
	/// <returns>true if it starts with the prefix after the offset, else false</returns>
	bool StartsWith(String prefix, int offset);

	/// <summary>
	/// Tells whether the rope ends with the specified suffix
	/// </summary>
	/// <param name="suffix">the specified suffix</param>
	/// <returns>true if it ends with the suffix, else false</returns>
	bool EndsWith(String suffix);

	/// <summary>
	/// Tells whether the rope ends with the specified suffix
	/// </summary>
	/// <param name="suffix">the specified suffix</param>
	/// <param name="offset">the specified offset</param>
	/// <returns>true if it ends with the suffix, else false</returns>
	bool EndsWith(String suffix, int offset);
}