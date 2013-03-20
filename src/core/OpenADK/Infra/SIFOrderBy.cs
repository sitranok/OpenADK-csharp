// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.Infra
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SIFOrderBy
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SIFOrderBy object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class SIFOrderBy : SifEnum
	{
	/// <summary>Descending ("Descending")</summary>
	public static readonly SIFOrderBy DESCENDING = new SIFOrderBy("Descending");

	/// <summary>Ascending ("Ascending")</summary>
	public static readonly SIFOrderBy ASCENDING = new SIFOrderBy("Ascending");

	///<summary>Wrap an arbitrary string value in a SIFOrderBy object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SIFOrderBy Wrap( String wrappedValue ) {
		return new SIFOrderBy( wrappedValue );
	}

	private SIFOrderBy( string enumDefValue ) : base( enumDefValue ) {}
	}
}
