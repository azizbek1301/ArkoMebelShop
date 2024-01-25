import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VxodComponent } from './vxod.component';

describe('VxodComponent', () => {
  let component: VxodComponent;
  let fixture: ComponentFixture<VxodComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [VxodComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(VxodComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
