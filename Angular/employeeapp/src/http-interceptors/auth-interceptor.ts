import { HttpEvent, HttpInterceptorFn } from "@angular/common/http";
import { Observable } from "rxjs";

export const AuthInterceptor:HttpInterceptorFn = (req, next): Observable<HttpEvent<any>>=> {
       const authToken = sessionStorage.getItem('token')??'';
       const authReq = req.clone({
        headers:req.headers.set('Authorization','Bearer '+authToken)
       })
       return next(authReq);
    }

