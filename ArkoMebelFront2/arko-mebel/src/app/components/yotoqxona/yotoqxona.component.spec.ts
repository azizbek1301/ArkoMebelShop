import { ComponentFixture, TestBed } from '@angular/core/testing';

import { YotoqxonaComponent } from './yotoqxona.component';

describe('YotoqxonaComponent', () => {
  let component: YotoqxonaComponent;
  let fixture: ComponentFixture<YotoqxonaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [YotoqxonaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(YotoqxonaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
