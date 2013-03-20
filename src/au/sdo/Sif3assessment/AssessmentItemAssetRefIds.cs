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

/// <summary>An AssessmentItemAssetRefIds</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class AssessmentItemAssetRefIds : SifKeyedList<AssessmentItemAssetRefId>
{
	/// <summary>
	/// Creates an instance of an AssessmentItemAssetRefIds
	/// </summary>
	public AssessmentItemAssetRefIds() : base ( Sif3assessmentDTD.ASSESSMENTITEMASSETREFIDS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentItemAssetRefId">An AssessmentItemAssetRefId</param>
	///
	public AssessmentItemAssetRefIds( AssessmentItemAssetRefId assessmentItemAssetRefId ) : base( Sif3assessmentDTD.ASSESSMENTITEMASSETREFIDS )
	{
		this.SafeAddChild( Sif3assessmentDTD.ASSESSMENTITEMASSETREFIDS_ASSESSMENTITEMASSETREFID, assessmentItemAssetRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentItemAssetRefIds( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.ASSESSMENTITEMASSETREFIDS_ASSESSMENTITEMASSETREFID }; }
	}

	///<summary>Adds the value of the <c>&lt;AssessmentItemAssetRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssessmentItemAssetRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentItemAssetRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssessmentItemAssetRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddAssessmentItemAssetRefId( string Value ) {
		AddChild( Sif3assessmentDTD.ASSESSMENTITEMASSETREFIDS_ASSESSMENTITEMASSETREFID, new AssessmentItemAssetRefId( Value ) );
	}

}}
