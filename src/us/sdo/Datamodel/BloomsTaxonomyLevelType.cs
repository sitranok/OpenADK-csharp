// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Datamodel
{
	///<summary>
	/// Defines the set of values that can be specified whenever a BloomsTaxonomyLevelType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a BloomsTaxonomyLevelType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	[Serializable]
	public class BloomsTaxonomyLevelType : SifEnum
	{
	/// <summary>Synthesis ("Synthesis")</summary>
	public static readonly BloomsTaxonomyLevelType SYNTHESIS = new BloomsTaxonomyLevelType("Synthesis");

	/// <summary>Comprehension ("Comprehension")</summary>
	public static readonly BloomsTaxonomyLevelType COMPREHENSION = new BloomsTaxonomyLevelType("Comprehension");

	/// <summary>Analysis ("Analysis")</summary>
	public static readonly BloomsTaxonomyLevelType ANALYSIS = new BloomsTaxonomyLevelType("Analysis");

	/// <summary>Evaluation ("Evaluation")</summary>
	public static readonly BloomsTaxonomyLevelType EVALUATION = new BloomsTaxonomyLevelType("Evaluation");

	/// <summary>Knowledge ("Knowledge")</summary>
	public static readonly BloomsTaxonomyLevelType KNOWLEDGE = new BloomsTaxonomyLevelType("Knowledge");

	/// <summary>Application ("Application")</summary>
	public static readonly BloomsTaxonomyLevelType APPLICATION = new BloomsTaxonomyLevelType("Application");

	///<summary>Wrap an arbitrary string value in a BloomsTaxonomyLevelType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static BloomsTaxonomyLevelType Wrap( String wrappedValue ) {
		return new BloomsTaxonomyLevelType( wrappedValue );
	}

	private BloomsTaxonomyLevelType( string enumDefValue ) : base( enumDefValue ) {}
	}
}