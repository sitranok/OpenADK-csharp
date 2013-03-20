// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ReporterDescriptionType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ReporterDescriptionType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class ReporterDescriptionType : SifEnum
	{
	/// <summary>Former student ("3168")</summary>
	public static readonly ReporterDescriptionType C1043_3168 = new ReporterDescriptionType("3168");

	/// <summary>Parent/guardian ("0850")</summary>
	public static readonly ReporterDescriptionType C1043_0850 = new ReporterDescriptionType("0850");

	/// <summary>Other nonstudent youth ("3062")</summary>
	public static readonly ReporterDescriptionType C1043_3062 = new ReporterDescriptionType("3062");

	/// <summary>Nonschool personnel ("3059")</summary>
	public static readonly ReporterDescriptionType C1043_3059 = new ReporterDescriptionType("3059");

	/// <summary>Other adult ("3061")</summary>
	public static readonly ReporterDescriptionType C1043_3061 = new ReporterDescriptionType("3061");

	/// <summary>Representative of visiting school ("3060")</summary>
	public static readonly ReporterDescriptionType C1043_3060 = new ReporterDescriptionType("3060");

	/// <summary>Unknown ("9997")</summary>
	public static readonly ReporterDescriptionType C1043_9997 = new ReporterDescriptionType("9997");

	/// <summary>Student ("0126")</summary>
	public static readonly ReporterDescriptionType C1043_0126 = new ReporterDescriptionType("0126");

	/// <summary>Staff member ("3422")</summary>
	public static readonly ReporterDescriptionType C1043_3422 = new ReporterDescriptionType("3422");

	/// <summary>Law enforcement officer ("3054")</summary>
	public static readonly ReporterDescriptionType C1043_3054 = new ReporterDescriptionType("3054");

	///<summary>Wrap an arbitrary string value in a ReporterDescriptionType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ReporterDescriptionType Wrap( String wrappedValue ) {
		return new ReporterDescriptionType( wrappedValue );
	}

	private ReporterDescriptionType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
