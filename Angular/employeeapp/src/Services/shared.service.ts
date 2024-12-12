import { Subject } from "rxjs";

export class SharedService{
    private messageSource = new Subject<string>();
    currentUser = this.messageSource.asObservable();

    setUser(username:string){
        this.messageSource.next(username);
    }
}