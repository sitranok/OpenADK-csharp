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

/// <summary>An AssessmentDescriptors</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class AssessmentDescriptors : SifKeyedList<AssessmentDescriptor>
{
	/// <summary>
	/// Creates an instance of an AssessmentDescriptors
	/// </summary>
	public AssessmentDescriptors() : base ( AssessmentDTD.ASSESSMENTDESCRIPTORS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentDescriptor">An AssessmentDescriptor</param>
	///
	public AssessmentDescriptors( AssessmentDescriptor assessmentDescriptor ) : base( AssessmentDTD.ASSESSMENTDESCRIPTORS )
	{
		this.SafeAddChild( AssessmentDTD.ASSESSMENTDESCRIPTORS_ASSESSMENTDESCRIPTOR, assessmentDescriptor );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentDescriptors( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;AssessmentDescriptor&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssessmentDescriptor&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentDescriptor</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssessmentDescriptor</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void AddAssessmentDescriptor( AssessmentDescriptorType Value ) {
		AddChild( AssessmentDTD.ASSESSMENTDESCRIPTORS_ASSESSMENTDESCRIPTOR, new AssessmentDescriptor( Value ) );
	}

}}
