// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A LearningResourceList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class LearningResourceList : SifKeyedList<LearningResourceRefId>
{
	/// <summary>
	/// Creates an instance of a LearningResourceList
	/// </summary>
	public LearningResourceList() : base ( Sif3assessmentDTD.LEARNINGRESOURCELIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learningResourceRefId">A LearningResourceRefId</param>
	///
	public LearningResourceList( LearningResourceRefId learningResourceRefId ) : base( Sif3assessmentDTD.LEARNINGRESOURCELIST )
	{
		this.SafeAddChild( Sif3assessmentDTD.LEARNINGRESOURCELIST_LEARNINGRESOURCEREFID, learningResourceRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LearningResourceList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.LEARNINGRESOURCELIST_LEARNINGRESOURCEREFID }; }
	}

	///<summary>Adds the value of the <c>&lt;LearningResourceRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;LearningResourceRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLearningResourceRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLearningResourceRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddLearningResourceRefId( string Value ) {
		AddChild( Sif3assessmentDTD.LEARNINGRESOURCELIST_LEARNINGRESOURCEREFID, new LearningResourceRefId( Value ) );
	}

}}
