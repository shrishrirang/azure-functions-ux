﻿import {Injectable, EventEmitter} from 'angular2/core';
import {IBroadcastService, BroadcastEvent} from './ibroadcast.service';
import {Observable, Subscription} from 'rxjs/Rx';
import {FunctionInfo} from '../models/function-info';

@Injectable()
export class BroadcastService implements IBroadcastService {
    public functionDeletedEvent: EventEmitter<FunctionInfo>;
    constructor() {
        this.functionDeletedEvent = new EventEmitter<FunctionInfo>();
    }

    broadcast<T>(eventType: BroadcastEvent, obj: T) {
        var emitter = <EventEmitter<T>>this.getEventEmitter(eventType);
        emitter.emit(obj);
    }

    subscribe<T>(eventType: BroadcastEvent, callback: (obj: T) => void, errorCallback?: (obj: any) => void, completedCallback?: (obj: any) => void): Subscription {
        var emitter = <EventEmitter<T>>this.getEventEmitter(eventType);
        return emitter.subscribe(callback, errorCallback, completedCallback);
    }

    getEventEmitter(eventType: BroadcastEvent): any {
        switch (eventType) {
            case BroadcastEvent.FunctionDeleted:
                return this.functionDeletedEvent;
        }
    }
}