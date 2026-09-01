Imports System
Module documento_de_identificacion
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim apellidos(9) As String
        Dim tiposDocumento(9) As String
        Dim numerosDocumento(9) As String
        Dim fechasNacimiento(9) As String
        Dim ciudades(9) As String
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------------'
        '--|menu_principal_documento_de_identificacion|--'
        '------------------------------------------------'
        Do
            Console.WriteLine("menu principal documento de identificacion")
            Console.WriteLine("1) Registrar documento")
            Console.WriteLine("2) Editar documento")
            Console.WriteLine("3) Listar documentos")
            Console.WriteLine("4) Buscar documento")
            Console.WriteLine("5) Eliminar documento")
            Console.WriteLine("6) Cambiar estado")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-------------------------'
                '--|registrar_documento|--'
                '-------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas documentos.")
                    Else
                        Console.Write("Ingrese el nombre: ")
                        Dim nuevoNombre As String = Console.ReadLine()
                        Console.Write("Ingrese el apellido: ")
                        Dim nuevoApellido As String = Console.ReadLine()
                        Console.WriteLine("Tipos de documento: CC | TI | CE | Pasaporte")
                        Console.Write("Ingrese el tipo de documento: ")
                        Dim nuevoTipo As String = Console.ReadLine()
                        Console.Write("Ingrese el numero de documento: ")
                        Dim nuevoNumero As String = Console.ReadLine()
                        Dim documentoExiste As Boolean = False
                        For i As Integer = 0 To cantidad - 1
                            If numerosDocumento(i) = nuevoNumero Then
                                documentoExiste = True
                            End If
                        Next
                        If documentoExiste Then
                            Console.WriteLine("No se puede registrar el documento. El numero de documento ya existe.")
                        Else
                            Console.Write("Ingrese la fecha de nacimiento (dd/mm/aaaa): ")
                            Dim nuevaFecha As String = Console.ReadLine()
                            Console.Write("Ingrese la ciudad de expedicion: ")
                            Dim nuevaCiudad As String = Console.ReadLine()
                            ids(cantidad) = cantidad + 1
                            nombres(cantidad) = nuevoNombre
                            apellidos(cantidad) = nuevoApellido
                            tiposDocumento(cantidad) = nuevoTipo
                            numerosDocumento(cantidad) = nuevoNumero
                            fechasNacimiento(cantidad) = nuevaFecha
                            ciudades(cantidad) = nuevaCiudad
                            estados(cantidad) = "Vigente"
                            cantidad += 1
                            Console.WriteLine("Documento registrado correctamente.")
                            Console.WriteLine("ID: " & ids(cantidad - 1) & " | Nombre: " & nombres(cantidad - 1) & " | Apellido: " & apellidos(cantidad - 1) & " | Tipo: " & tiposDocumento(cantidad - 1) & " | Documento: " & numerosDocumento(cantidad - 1) & " | Nacimiento: " & fechasNacimiento(cantidad - 1) & " | Ciudad: " & ciudades(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                        End If
                    End If
                '----------------------'
                '--|editar_documento|--'
                '----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen documentos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Tipo: " & tiposDocumento(i) & " | Documento: " & numerosDocumento(i) & " | Nacimiento: " & fechasNacimiento(i) & " | Ciudad: " & ciudades(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del documento a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nuevo apellido: ")
                            apellidos(posicion) = Console.ReadLine()
                            Console.WriteLine("Tipos de documento: CC | TI | CE | Pasaporte")
                            Console.Write("Nuevo tipo de documento: ")
                            tiposDocumento(posicion) = Console.ReadLine()
                            Console.Write("Nuevo numero de documento: ")
                            Dim nuevoNumero As String = Console.ReadLine()
                            Dim documentoExiste As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If i <> posicion AndAlso numerosDocumento(i) = nuevoNumero Then
                                    documentoExiste = True
                                End If
                            Next
                            If documentoExiste Then
                                Console.WriteLine("No se puede actualizar. El numero de documento ya existe.")
                            Else
                                numerosDocumento(posicion) = nuevoNumero
                                Console.Write("Nueva fecha de nacimiento (dd/mm/aaaa): ")
                                fechasNacimiento(posicion) = Console.ReadLine()
                                Console.Write("Nueva ciudad de expedicion: ")
                                ciudades(posicion) = Console.ReadLine()
                                Console.WriteLine("Documento actualizado correctamente.")
                                Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Apellido: " & apellidos(posicion) & " | Tipo: " & tiposDocumento(posicion) & " | Documento: " & numerosDocumento(posicion) & " | Nacimiento: " & fechasNacimiento(posicion) & " | Ciudad: " & ciudades(posicion) & " | Estado: " & estados(posicion))
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|listar_documentos|--'
                '-----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen documentos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Tipo: " & tiposDocumento(i) & " | Documento: " & numerosDocumento(i) & " | Nacimiento: " & fechasNacimiento(i) & " | Ciudad: " & ciudades(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '----------------------'
                '--|buscar_documento|--'
                '----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen documentos registrados.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por numero de documento")
                        Console.WriteLine("3) Buscar por nombre")
                        Console.WriteLine("4) Buscar por apellido")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Apellido: " & apellidos(posicion) & " | Tipo: " & tiposDocumento(posicion) & " | Documento: " & numerosDocumento(posicion) & " | Nacimiento: " & fechasNacimiento(posicion) & " | Ciudad: " & ciudades(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el numero de documento: ")
                            Dim numeroBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If numerosDocumento(i) = numeroBuscar Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Tipo: " & tiposDocumento(i) & " | Documento: " & numerosDocumento(i) & " | Nacimiento: " & fechasNacimiento(i) & " | Ciudad: " & ciudades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron documentos.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese el nombre: ")
                            Dim nombreBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If nombres(i).ToLower().Contains(nombreBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Tipo: " & tiposDocumento(i) & " | Documento: " & numerosDocumento(i) & " | Nacimiento: " & fechasNacimiento(i) & " | Ciudad: " & ciudades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron personas.")
                            End If
                        ElseIf tipoBusqueda = 4 Then
                            Console.Write("Ingrese el apellido: ")
                            Dim apellidoBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If apellidos(i).ToLower().Contains(apellidoBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Tipo: " & tiposDocumento(i) & " | Documento: " & numerosDocumento(i) & " | Nacimiento: " & fechasNacimiento(i) & " | Ciudad: " & ciudades(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron personas.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '------------------------'
                '--|eliminar_documento|--'
                '------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen documentos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Tipo: " & tiposDocumento(i) & " | Documento: " & numerosDocumento(i) & " | Nacimiento: " & fechasNacimiento(i) & " | Ciudad: " & ciudades(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del documento a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                apellidos(i) = apellidos(i + 1)
                                tiposDocumento(i) = tiposDocumento(i + 1)
                                numerosDocumento(i) = numerosDocumento(i + 1)
                                fechasNacimiento(i) = fechasNacimiento(i + 1)
                                ciudades(i) = ciudades(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            nombres(cantidad) = ""
                            apellidos(cantidad) = ""
                            tiposDocumento(cantidad) = ""
                            numerosDocumento(cantidad) = ""
                            fechasNacimiento(cantidad) = ""
                            ciudades(cantidad) = ""
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Documento eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------'
                '--|cambiar_estado|--'
                '--------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen documentos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Documento: " & numerosDocumento(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del documento: ")
                        Dim idEstado As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEstado >= 1 AndAlso idEstado <= cantidad Then
                            Dim posicion As Integer = idEstado - 1
                            Console.WriteLine("1) Vigente")
                            Console.WriteLine("2) Vencido")
                            Console.WriteLine("3) Inactivo")
                            Console.Write("Seleccione el nuevo estado: ")
                            Dim opcionEstado As Integer = Convert.ToInt32(Console.ReadLine())
                            Select Case opcionEstado
                                Case 1
                                    estados(posicion) = "Vigente"
                                Case 2
                                    estados(posicion) = "Vencido"
                                Case 3
                                    estados(posicion) = "Inactivo"
                                Case Else
                                    Console.WriteLine("Opcion de estado no valida.")
                                    Continue Do
                            End Select
                            Console.WriteLine("Estado actualizado correctamente.")
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Apellido: " & apellidos(posicion) & " | Tipo: " & tiposDocumento(posicion) & " | Documento: " & numerosDocumento(posicion) & " | Nacimiento: " & fechasNacimiento(posicion) & " | Ciudad: " & ciudades(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Documento de Identificacion.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module