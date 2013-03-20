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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Assessment{

/// <summary>A SectionIdentifiers</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class SectionIdentifiers : SifKeyedList<SectionIdentifier>
{
	/// <summary>
	/// Creates an instance of a SectionIdentifiers
	/// </summary>
	public SectionIdentifiers() : base ( AssessmentDTD.SECTIONIDENTIFIERS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sectionIdentifier">If the authoring system provides for a unique identification system for sections, then this element is used to store that information.</param>
	///
	public SectionIdentifiers( SectionIdentifier sectionIdentifier ) : base( AssessmentDTD.SECTIONIDENTIFIERS )
	{
		this.SafeAddChild( AssessmentDTD.SECTIONIDENTIFIERS_SECTIONIDENTIFIER, sectionIdentifier );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SectionIdentifiers( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SECTIONIDENTIFIERS_SECTIONIDENTIFIER }; }
	}

	///<summary>Adds the value of the <c>&lt;SectionIdentifier&gt;</c> element.</summary>
	/// <param name="SectionIdentifierType">Identifies the type of section identifier using a enumerated list.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;SectionIdentifier&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSectionIdentifier</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSectionIdentifier</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddSectionIdentifier( SectionIdentifierType SectionIdentifierType, string Value ) {
		AddChild( AssessmentDTD.SECTIONIDENTIFIERS_SECTIONIDENTIFIER, new SectionIdentifier( SectionIdentifierType, Value ) );
	}

}}
