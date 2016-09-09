﻿Imports System
Imports System.Collections.ObjectModel
Imports System.Data.Linq.Mapping

Namespace Northwind

   <Table(Name:="CustomerDemographics")>
   Public Class CustomerDemographic

      <Column(UpdateCheck:=UpdateCheck.Never)>
      Public Property CustomerDesc As String

      <Column(IsPrimaryKey:=True)>
      Public Property CustomerTypeID As String

      <Association(OtherKey:=NameOf(CustomerCustomerDemo.CustomerTypeID))>
      Public ReadOnly Property CustomerCustomerDemos As New Collection(Of CustomerCustomerDemo)

   End Class

End Namespace

