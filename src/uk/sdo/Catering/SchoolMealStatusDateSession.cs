// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Catering
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SchoolMealStatusDateSession
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SchoolMealStatusDateSession object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class SchoolMealStatusDateSession : SifEnum
	{
	/// <summary>PM ("PM")</summary>
	public static readonly SchoolMealStatusDateSession PM = new SchoolMealStatusDateSession("PM");

	/// <summary>AM ("AM")</summary>
	public static readonly SchoolMealStatusDateSession AM = new SchoolMealStatusDateSession("AM");

	///<summary>Wrap an arbitrary string value in a SchoolMealStatusDateSession object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SchoolMealStatusDateSession Wrap( String wrappedValue ) {
		return new SchoolMealStatusDateSession( wrappedValue );
	}

	private SchoolMealStatusDateSession( string enumDefValue ) : base( enumDefValue ) {}
	}
}
