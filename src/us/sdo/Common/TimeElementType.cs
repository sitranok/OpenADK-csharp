// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a TimeElementType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a TimeElementType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class TimeElementType : SifEnum
	{
	/// <summary>Full school year ("Full school year")</summary>
	public static readonly TimeElementType FULL_SCHOOL_YEAR = new TimeElementType("Full school year");

	/// <summary>Semester ("Semester")</summary>
	public static readonly TimeElementType SEMESTER = new TimeElementType("Semester");

	/// <summary>Mini-term ("Mini-term")</summary>
	public static readonly TimeElementType MINI_TERM = new TimeElementType("Mini-term");

	/// <summary>Summer Term ("Summer Term")</summary>
	public static readonly TimeElementType SUMMER_TERM = new TimeElementType("Summer Term");

	/// <summary>Other ("Other")</summary>
	public static readonly TimeElementType OTHER = new TimeElementType("Other");

	/// <summary>Spring Vacationj ("Spring Vacationj")</summary>
	public static readonly TimeElementType SPRING_VACATIONJ = new TimeElementType("Spring Vacationj");

	/// <summary>Intercession ("Intercession")</summary>
	public static readonly TimeElementType INTERCESSION = new TimeElementType("Intercession");

	/// <summary>Long session ("Long session")</summary>
	public static readonly TimeElementType LONG_SESSION = new TimeElementType("Long session");

	/// <summary>Quarter ("Quarter")</summary>
	public static readonly TimeElementType QUARTER = new TimeElementType("Quarter");

	/// <summary>Trimester ("Trimester")</summary>
	public static readonly TimeElementType TRIMESTER = new TimeElementType("Trimester");

	///<summary>Wrap an arbitrary string value in a TimeElementType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static TimeElementType Wrap( String wrappedValue ) {
		return new TimeElementType( wrappedValue );
	}

	private TimeElementType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
