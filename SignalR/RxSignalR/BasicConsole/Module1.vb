﻿Option Strict Off

Imports SignalR.Client.Hubs
Imports System.Reactive.Linq
Imports Newtonsoft.Json.Linq

Module Module1

    Sub Main()
        Dim cn = New HubConnection("http://localhost:4734")
        Dim sensor = cn.CreateProxy("observableSensorHub")
        Dim items = From item In sensor.Observe("broadcast")
                    Let instance = item(0).ToObject(Of SensorData)()
                    Where instance.Value < 5
                    Select instance

        Using items.Subscribe(Sub(value) Console.WriteLine(value.Value))

            cn.Start().Wait()
            Console.ReadLine()

        End Using

    End Sub

End Module