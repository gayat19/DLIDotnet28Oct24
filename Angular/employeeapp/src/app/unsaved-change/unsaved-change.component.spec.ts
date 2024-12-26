import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UnsavedChangeComponent } from './unsaved-change.component';

describe('UnsavedChangeComponent', () => {
  let component: UnsavedChangeComponent;
  let fixture: ComponentFixture<UnsavedChangeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UnsavedChangeComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UnsavedChangeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
