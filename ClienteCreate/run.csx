#r "Microsoft.Azure.Documents.Client"

using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;
using System.Net;
using System.Net.Http.Formatting;

public static HttpResponseMessage Run(Cliente cliente, TraceWriter log, out object document)
{

    cliente.id = Guid.NewGuid().ToString();

    log.Info($"Cliente criado: {cliente.id}");

    HttpResponseMessage response = new HttpResponseMessage();

    response.Content = new ObjectContent<object>(new {id = cliente.id}, new JsonMediaTypeFormatter(), "application/json");
    response.StatusCode = HttpStatusCode.OK;
    return response;
}

public class Cliente
{
    public string id { get; set; }
    public string Nome { get; set; }
}
 