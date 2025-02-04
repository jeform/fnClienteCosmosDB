#r "Microsoft.Azure.Documents.Client"

using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Net;
using System.Net.Http.Formatting;

public static HttpResponseMessage Run(HttpResponseMessage req, string clienteId, TraceWriter log, dynamic customer)
{

    var castedCliente = (Cliente)cliente;
    log.Info($"Ler o cliente com o id: {clienteId}");

    HttpResponseMessage response = new HttpResponseMessage();

    response.Content = new ObjectContent<Customer>(castedCustomer, new JsonMediaTypeFormatter(), "application/json");
    response.StatusCode = HttpStatusCode.OK;

    return response;
}

public class Cliente
{
    public string Id { get; set; }
    public string Nome { get; set; }
}