﻿' ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в контекстном меню, чтобы изменить имя интерфейса "IService" в коде и файле конфигурации.
<ServiceContract()>
Public Interface IService

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: Добавьте здесь операции служб

End Interface

' Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean
    <DataMember()>
    Public Property StringValue() As String

End Class
