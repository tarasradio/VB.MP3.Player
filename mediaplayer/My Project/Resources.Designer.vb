﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.42000
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Этот класс создан автоматически классом StronglyTypedResourceBuilder
    'с помощью такого средства, как ResGen или Visual Studio.
    'Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    'с параметром /str или перестройте свой проект VS.
    '''<summary>
    '''  Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("mediaplayer.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Перезаписывает свойство CurrentUICulture текущего потока для всех
        '''  обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на 300; 160.
        '''</summary>
        Friend ReadOnly Property _String() As String
            Get
                Return ResourceManager.GetString("String", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property backwardIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("backwardIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property forwardIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("forwardIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property minusIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("minusIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property pauseIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("pauseIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property playIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("playIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property plusIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("plusIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace