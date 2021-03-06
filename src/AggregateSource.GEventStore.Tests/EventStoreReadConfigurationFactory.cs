﻿namespace AggregateSource.GEventStore {
  public static class EventStoreReadConfigurationFactory {
    public static EventStoreReadConfiguration NewInstance() {
      return new EventStoreReadConfiguration(new SliceSize(1), new ResolvedEventDeserializer());
    }
  }
}