// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learning
{
	///<summary>
	/// Defines the set of values that can be specified whenever an InputType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an InputType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class InputType : SifEnum
	{
	/// <summary>School ("SC")</summary>
	public static readonly InputType SC_SCHOOL = new InputType("SC");

	///<summary>Wrap an arbitrary string value in an InputType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static InputType Wrap( String wrappedValue ) {
		return new InputType( wrappedValue );
	}

	private InputType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
