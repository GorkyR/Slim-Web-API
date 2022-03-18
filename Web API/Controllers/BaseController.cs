using Microsoft.AspNetCore.Mvc;
using WebAPI.Views;

namespace WebAPI.Controllers;

[ApiController]
[Route("")]
public class BaseController: ControllerBase {
   protected readonly Core.Logic Core;

   protected Task<IActionResult> Execute<T>(Func<Task<T>> responder) => WrapResponse(responder);



   async Task<IActionResult> WrapResponse<T>(Func<Task<T>> function) {
      try {
         var data = await function();
         if (data is Task)
            throw new Exception("Endpoint returned task not awaited.  Check endpoint body in API controller; await the task.");
         return Ok(Response<T>.Succeed(data));
      } catch (Exception ex) {
         ex = Unwrap(ex);
         var error = ex as Core.Errors.Error;
         if (error is not null) {
            var response = Response<T>.Fail(error);

            return BadRequest(response);
         } else {
            // @TODO(Gorky): log internal error
            return StatusCode(500, Response<T>.Fail(ex));
         }
      }

      static Exception Unwrap(Exception ex) => ex.InnerException is not null ? Unwrap(ex.InnerException) : ex;
   }
}