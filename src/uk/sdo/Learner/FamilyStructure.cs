// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever a FamilyStructure
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FamilyStructure object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class FamilyStructure : SifEnum
	{
	/// <summary>In Residental Care ("C")</summary>
	public static readonly FamilyStructure IN_RES_CARE = new FamilyStructure("C");

	/// <summary>Unknown ("U")</summary>
	public static readonly FamilyStructure UNKNOWN = new FamilyStructure("U");

	/// <summary>Foster Parents ("F")</summary>
	public static readonly FamilyStructure FOSTER_PARENTS = new FamilyStructure("F");

	/// <summary>Single Parent ("S")</summary>
	public static readonly FamilyStructure SINGLE_PARENT = new FamilyStructure("S");

	/// <summary>2 Adults ("A")</summary>
	public static readonly FamilyStructure TWO_ADULTS = new FamilyStructure("A");

	///<summary>Wrap an arbitrary string value in a FamilyStructure object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FamilyStructure Wrap( String wrappedValue ) {
		return new FamilyStructure( wrappedValue );
	}

	private FamilyStructure( string enumDefValue ) : base( enumDefValue ) {}
	}
}
