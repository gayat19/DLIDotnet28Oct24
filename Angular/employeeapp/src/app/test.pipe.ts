import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'test'
})
export class TestPipe implements PipeTransform {

  transform(value: unknown,
     ...args: unknown[]): string {
    var data = value as string;
    var length = 100;
    if(args[0])
    {
      length= args[0] as number;
    }
    data = data.substring(0,length)+'...';
    return data;
  }

}
