// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Sif3assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a GraduationOnTimeEnum
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a GraduationOnTimeEnum object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class GraduationOnTimeEnum : SifEnum
	{
	/// <summary>NA ("NA")</summary>
	public static readonly GraduationOnTimeEnum NA = new GraduationOnTimeEnum("NA");

	/// <summary>Yes ("Yes")</summary>
	public static readonly GraduationOnTimeEnum YES = new GraduationOnTimeEnum("Yes");

	/// <summary>Unavailable ("Unavailable")</summary>
	public static readonly GraduationOnTimeEnum UNAVAILABLE = new GraduationOnTimeEnum("Unavailable");

	/// <summary>No ("No")</summary>
	public static readonly GraduationOnTimeEnum NO = new GraduationOnTimeEnum("No");

	///<summary>Wrap an arbitrary string value in a GraduationOnTimeEnum object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static GraduationOnTimeEnum Wrap( String wrappedValue ) {
		return new GraduationOnTimeEnum( wrappedValue );
	}

	private GraduationOnTimeEnum( string enumDefValue ) : base( enumDefValue ) {}
	}
}
