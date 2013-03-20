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
	/// Defines the set of values that can be specified whenever a Gender
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a Gender object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class Gender : SifEnum
	{
	/// <summary>Female ("F")</summary>
	public static readonly Gender FEMALE = new Gender("F");

	/// <summary>Unknown ("U")</summary>
	public static readonly Gender U = new Gender("U");

	/// <summary>Unknown ("U")</summary>
	public static readonly Gender UNKNOWN = new Gender("U");

	/// <summary>Female ("F")</summary>
	public static readonly Gender F = new Gender("F");

	/// <summary>Male ("M")</summary>
	public static readonly Gender MALE = new Gender("M");

	/// <summary>Male ("M")</summary>
	public static readonly Gender M = new Gender("M");

	///<summary>Wrap an arbitrary string value in a Gender object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static Gender Wrap( String wrappedValue ) {
		return new Gender( wrappedValue );
	}

	private Gender( string enumDefValue ) : base( enumDefValue ) {}
	}
}
