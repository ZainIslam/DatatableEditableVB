Imports System.Web.Mvc

Public Class CompanyController
    Inherits Controller

    Public Function Index() As ActionResult
        Dim companies = DataRepository.GetCompanies()
        Return View(companies)
    End Function

    Public Function Ajax() As ActionResult
        Return View()
    End Function

    Public Function Customization() As ActionResult
        Dim companies = DataRepository.GetCompanies()
        Return View(companies)
    End Function

    Public Function IndividualColumnEditing() As ActionResult
        Dim companies = DataRepository.GetCompanies()
        Return View(companies)
    End Function

    Public Function AjaxDataProvider(ByVal param As JQueryDataTableParamModel) As ActionResult
        Dim allCompanies = DataRepository.GetCompanies()
        Dim filteredCompanies As IEnumerable(Of Company)

        If Not String.IsNullOrEmpty(param.sSearch) Then
            Dim nameFilter = Convert.ToString(Request("sSearch_1"))
            Dim addressFilter = Convert.ToString(Request("sSearch_2"))
            Dim townFilter = Convert.ToString(Request("sSearch_3"))
            Dim isNameSearchable = Convert.ToBoolean(Request("bSearchable_1"))
            Dim isAddressSearchable = Convert.ToBoolean(Request("bSearchable_2"))
            Dim isTownSearchable = Convert.ToBoolean(Request("bSearchable_3"))
            filteredCompanies = DataRepository.GetCompanies().Where(Function(c) isNameSearchable AndAlso c.Name.ToLower().Contains(param.sSearch.ToLower()) OrElse isAddressSearchable AndAlso c.Address.ToLower().Contains(param.sSearch.ToLower()) OrElse isTownSearchable AndAlso c.Town.ToLower().Contains(param.sSearch.ToLower()))
        Else
            filteredCompanies = allCompanies
        End If

        Dim isNameSortable = Convert.ToBoolean(Request("bSortable_1"))
        Dim isAddressSortable = Convert.ToBoolean(Request("bSortable_2"))
        Dim isTownSortable = Convert.ToBoolean(Request("bSortable_3"))
        Dim sortColumnIndex = Convert.ToInt32(Request("iSortCol_0"))
        Dim orderingFunction As Func(Of Company, String) = (Function(c) If(sortColumnIndex = 1 AndAlso isNameSortable, c.Name, If(sortColumnIndex = 2 AndAlso isAddressSortable, c.Address, If(sortColumnIndex = 3 AndAlso isTownSortable, c.Town, ""))))
        Dim sortDirection = Request("sSortDir_0")

        If sortDirection = "asc" Then
            filteredCompanies = filteredCompanies.OrderBy(orderingFunction)
        Else
            filteredCompanies = filteredCompanies.OrderByDescending(orderingFunction)
        End If

        Dim displayedCompanies = filteredCompanies.Skip(param.iDisplayStart).Take(param.iDisplayLength)
        Dim result = From c In displayedCompanies Select {Convert.ToString(c.ID), c.Name, c.Address, c.Town}
            Return Json(New With {Key.sEcho = param.sEcho, Key.iTotalRecords = allCompanies.Count(), Key.iTotalDisplayRecords = filteredCompanies.Count(), Key.aaData = result
            }, JsonRequestBehavior.AllowGet)
    End Function

    Public Function DeleteData(ByVal id As Integer) As String
        Try
            Dim company = DataRepository.GetCompanies().FirstOrDefault(Function(c) c.ID = id)
            If company Is Nothing Then Return "Company cannot be found"
            DataRepository.GetCompanies().Remove(company)
            Return "ok"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function UpdateData(ByVal id As Integer, ByVal value As String, ByVal rowId As Integer?, ByVal columnPosition As Integer?, ByVal columnId As Integer?, ByVal columnName As String) As String
        Dim companies = DataRepository.GetCompanies()
        If columnPosition = 0 AndAlso companies.Any(Function(c) c.Name.ToLower().Equals(value.ToLower())) Then Return "Company with a name '" & value & "' already exists"
        Dim company = companies.FirstOrDefault(Function(c) c.ID = id)

        If company Is Nothing Then
            Return "Company with an id = " & id & " does not exists"
        End If

        Select Case columnPosition
            Case 0
                company.Name = value
            Case 1
                company.Address = value
            Case 2
                company.Town = value
            Case Else
        End Select

        Return value
    End Function

    Public Function AddData(ByVal name As String, ByVal address As String, ByVal town As String, ByVal country As Integer?) As Integer
        Dim companies = DataRepository.GetCompanies()

        If companies.Any(Function(c) c.Name.ToLower().Equals(name.ToLower())) Then
            Response.Write("Company with the name '" & name & "' already exists")
            Response.StatusCode = 404
            Response.[End]()
            Return -1
        End If

        Dim company = New Company()
        company.Name = name
        company.Address = address
        company.Town = town
        companies.Add(company)
        Return company.ID
    End Function
End Class

Public Class JQueryDataTableParamModel
    Public Property sEcho As String
    Public Property sSearch As String
    Public Property iDisplayLength As Integer
    Public Property iDisplayStart As Integer
    Public Property iColumns As Integer
    Public Property iSortingCols As Integer
    Public Property sColumns As String
End Class