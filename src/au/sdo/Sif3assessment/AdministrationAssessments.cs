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

/// <summary>An AdministrationAssessments</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class AdministrationAssessments : SifKeyedList<AdministrationAssessment>
{
	/// <summary>
	/// Creates an instance of an AdministrationAssessments
	/// </summary>
	public AdministrationAssessments() : base ( Sif3assessmentDTD.ADMINISTRATIONASSESSMENTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="administrationAssessment">An AdministrationAssessment</param>
	///
	public AdministrationAssessments( AdministrationAssessment administrationAssessment ) : base( Sif3assessmentDTD.ADMINISTRATIONASSESSMENTS )
	{
		this.SafeAddChild( Sif3assessmentDTD.ADMINISTRATIONASSESSMENTS_ADMINISTRATIONASSESSMENT, administrationAssessment );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AdministrationAssessments( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.ADMINISTRATIONASSESSMENTS_ADMINISTRATIONASSESSMENT }; }
	}

	///<summary>Adds the value of the <c>&lt;AdministrationAssessment&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AdministrationAssessment&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAdministrationAssessment</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAdministrationAssessment</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddAdministrationAssessment( string Value ) {
		AddChild( Sif3assessmentDTD.ADMINISTRATIONASSESSMENTS_ADMINISTRATIONASSESSMENT, new AdministrationAssessment( Value ) );
	}

}}
